using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.UnitTest.Repositories
{
    [TestFixture]
    public class CommentRepositoryTests
    {
        private ICommentRepository _repository;
        private Mock<JustBlogContext> _context;
        private Mock<DbSet<Comment>> _dbSet;
        private IQueryable<Comment> data;
        [SetUp]
        public void SetUp()
        {
            _dbSet = new Mock<DbSet<Comment>>();
            data = new List<Comment>()
            {
           new Comment
           {
               Id=1,
               PostId=1,
               Status=Status.Actived
           },
           new Comment
           {
               Id=2,
               PostId=1,
               Status=Status.Actived
           },
           new Comment
           {
               Id=3,
               PostId=2,
               Status=Status.Actived
           },
           new Comment
           {
               Id=3,
               PostId=1,
               Status=Status.Deleted
           }
            }.AsQueryable();
            _dbSet.As<IQueryable<Comment>>().Setup(m => m.Provider).Returns(data.Provider);
            _dbSet.As<IQueryable<Comment>>().Setup(m => m.Expression).Returns(data.Expression);
            _dbSet.As<IQueryable<Comment>>().Setup(m => m.ElementType).Returns(data.ElementType);
            _dbSet.As<IQueryable<Comment>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            _context = new Mock<JustBlogContext>();
            _context.Setup(x => x.Set<Comment>()).Returns(_dbSet.Object);

            _repository = new CommentRepository(_context.Object);
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void GetCommentsForPost_WhenCall_ReturnCategoryWithSearchId(int id)
        {
            //Arrange
            var expected = data.Where(t => t.PostId == id&&t.Status==Status.Actived)
                .ToList();

            //Act
            var category = _repository.GetCommentsForPost(id);

            //Assert
            Assert.AreEqual(expected, category);
        }
     
    }
}
