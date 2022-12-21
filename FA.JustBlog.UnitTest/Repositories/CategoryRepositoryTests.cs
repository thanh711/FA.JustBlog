using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;

namespace FA.JustBlog.UnitTest.Repositories
{
    [TestFixture]
    public class CategoryRepositoryTests
    {
        private ICategoryRepository _repository;
        private Mock<JustBlogContext> _context;
        private Mock<DbSet<Category>> _dbSet;
        private IQueryable<Category> data;
        [SetUp]
        public void SetUp()
        {
            _dbSet = new Mock<DbSet<Category>>();
            data = new List<Category>()
            {
            new Category
            {
                Id = 11,
                Name = "Category Name",
                UrlSlug = "Category UrlSlug",
                Description = "Category Description",
                 CreateAt=DateTime.Now,
                 UpdateAt=DateTime.Now,
                 Status=Status.Actived

            },
            new Category
            {
                Id = 12,
                Name = "Category Name 2",
                UrlSlug = "Category UrlSlug 2",
                Description = "Category Description 2",
                CreateAt=DateTime.Now,
                UpdateAt=DateTime.Now,
                Status=Status.Deleted

            },
            new Category
            {
                Id = 13,
                Name = "Category Name 3",
                UrlSlug = "Category UrlSlug 3",
                Description = "Category Description 3",
                CreateAt=DateTime.Now,
                UpdateAt=DateTime.Now,
                Status=Status.Actived

            }
            }.AsQueryable();
            _dbSet.As<IQueryable<Category>>().Setup(m => m.Provider).Returns(data.Provider);
            _dbSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(data.Expression);
            _dbSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(data.ElementType);
            _dbSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            _context = new Mock<JustBlogContext>();
            _context.Setup(x => x.Set<Category>()).Returns(_dbSet.Object);

            _repository = new CategoryRepository(_context.Object);
        }

        #region Test 'GetById()' method
        [Test]
        [TestCase(11)]
        [TestCase(12)]
        public void GetById_WhenCall_ReturnCategoryWithSearchId(int id)
        {
            //Arrange
            var expected = data.Where(t=>t.Status==Status.Actived).FirstOrDefault(t => t.Id == id);
            _dbSet.Setup(t => t.Find(id)).Returns(data.FirstOrDefault(t => t.Id == id));

            //Act
            var category = _repository.GetById(id);

            //Assert
            Assert.AreEqual(expected, category);
        }
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void GetById_IdNotExit_ReturnNull(int id)
        {
            //Arrange
            _dbSet.Setup(t => t.Find(id)).Returns(data.FirstOrDefault(t => t.Id == id));

            //Act
            var category = _repository.GetById(id);

            //Assert
            Assert.IsNull(category);
        }
        #endregion

        #region Test 'Create()' method
        [Test]
        public void Create_WhenCall_AddTheCategory()
        {
            //Arrange
            Category category = new Category
            {
                Name = "new Category Name",
                UrlSlug = "new Category UrlSlug",
                Description = "new Category Description"
            };

            //Act
            _repository.Create(category);

            //Assert
            _dbSet.Verify(t => t.Add(category), Times.Once());
        }

        #endregion

        #region Test 'Update()' method
        [Test]
        public void Update_WhenCall_UpdateTheCategory()
        {
            //Arrange
            Category category = new Category
            {
                Id = 13,
                Name = "new update Category Name",
                UrlSlug = "new update Category UrlSlug",
                Description = "new update Category Description"
            };

            //Act
            _repository.Update(category);

            //Assert
            _dbSet.Verify(t => t.Update(category), Times.Once());
        }
        #endregion

        #region Test 'Delete()' method
        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void DeleteById_WhenCall_ChangeCategoryStatusToDeleted(int id)
        {
            //Arrange
            var category = data.FirstOrDefault(t => t.Id == id);
            _dbSet.Setup(t => t.Find(id)).Returns(category);
            var expectedStatus = Status.Deleted;
            //Act
            _repository.Delete(id);

            //Assert
            _dbSet.Verify(t => t.Update(category), Times.Once());
            Assert.That(expectedStatus, Is.EqualTo(category.Status));
        }
        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void Delete_WhenCall_ChangeCategoryStatusToDeleted(int id)
        {
            //Arrange
            var category = data.FirstOrDefault(t => t.Id == id);
            var expectedStatus=Status.Deleted;

            //Act
            _repository.Delete(category);

            //Assert
            _dbSet.Verify(t => t.Update(category), Times.Once());
            Assert.That(expectedStatus,Is.EqualTo(category.Status));
        }
        #endregion

        #region Test 'GetAll()' method
        [Test]
        public void GetAll_WhenCall_ReturnListCategories()
        {
            //Arrange
            var expected= data.Where(t => t.Status == Status.Actived).ToList();

            //Act
            var listCategories = _repository.GetAll();

            //Assert
            Assert.AreEqual(expected, listCategories);
        }
        #endregion
    }
}
