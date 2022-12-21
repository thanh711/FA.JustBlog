using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace FA.JustBlog.UnitTest.Repositories
{
    [TestFixture]
    public class TagRepositoryTests
    {
        private ITagRepository _repository;
        private Mock<JustBlogContext> _context;
        private Mock<DbSet<Tag>> _dbSet;
        private IQueryable<Tag> data;
        [SetUp]
        public void SetUp()
        {
            _dbSet = new Mock<DbSet<Tag>>();
            data = new List<Tag>()
            {
            new Tag
               {
                   Id = 1,
                   Name = "Tag Name demo:" + 1,
                   UrlSlug = "Tag UrlSlug demo:" + 1,
                   Description = "Tag Description demo:" + 1,
                   Count = 1,
                 CreateAt=DateTime.Now,
                 UpdateAt=DateTime.Now,
                 Status=Status.Actived
               },
                new Tag
                {
                    Id = 2,
                    Name = "Tag Name demo:" + 2,
                    UrlSlug = "Tag UrlSlug demo:" + 2,
                    Description = "Tag Description demo:" + 2,
                    Count = 2,
                 CreateAt=DateTime.Now,
                 UpdateAt=DateTime.Now,
                 Status=Status.Actived
                },
                new Tag
                {
                    Id = 3,
                    Name = "Tag Name demo:" + 3,
                    UrlSlug = "Tag UrlSlug demo:" + 3,
                    Description = "Tag Description demo:" + 3,
                    Count = 3,
                 CreateAt=DateTime.Now,
                 UpdateAt=DateTime.Now,
                 Status=Status.Actived
                }
            }.AsQueryable();
            _dbSet.As<IQueryable<Tag>>().Setup(m => m.Provider).Returns(data.Provider);
            _dbSet.As<IQueryable<Tag>>().Setup(m => m.Expression).Returns(data.Expression);
            _dbSet.As<IQueryable<Tag>>().Setup(m => m.ElementType).Returns(data.ElementType);
            _dbSet.As<IQueryable<Tag>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            _context = new Mock<JustBlogContext>();
            _context.Setup(x => x.Set<Tag>()).Returns(_dbSet.Object);

            _repository = new TagRepository(_context.Object);
        }

        /*
         Because GetById(),Create(),Update(),Delete(),GetAll() is written in BaseRepository
         and already test in 'CategoryRepositoryTests' it will not be tested here
         */

        [Test]
        [TestCase("Tag UrlSlug demo:1")]
        [TestCase("Tag UrlSlug demo:2")]
        public void GetTagByUrlSlug_WhenCall_ReturnTag(string urlSlug)
        {
            //Arrange
            var expected = data.FirstOrDefault(t=>t.UrlSlug==urlSlug);
            //Act
            var actual = _repository.GetTagByUrlSlug(urlSlug);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));

        }
        [Test]
        [TestCase("Tag UrlSlug :1")]
        [TestCase("Tag UrlSlug :2")]
        public void GetTagByUrlSlug_NotExistUrlSlug_ReturnNull(string urlSlug)
        {
            //Arrange
            //Act
            var actual = _repository.GetTagByUrlSlug(urlSlug);

            //Assert
            Assert.IsNull(actual);
        }
    }
}
