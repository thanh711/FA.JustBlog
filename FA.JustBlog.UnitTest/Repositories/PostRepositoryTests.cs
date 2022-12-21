using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.UnitTest.Repositories
{
    [TestFixture]
    public class PostRepositoryTests
    {
        private IPostRepository _repository;
        private Mock<JustBlogContext> _context;
        private Mock<DbSet<Post>> _dbSet;
        private IQueryable<Post> data;

        private Mock<DbSet<PostTagMap>> _dbPostTagMapSet;
        private IQueryable<PostTagMap> postTagMapData;

        private Mock<DbSet<Category>> _dbCategorySet;
        private IQueryable<Category> categoryData;

        private Mock<DbSet<Tag>> _dbTagSet;
        private IQueryable<Tag> tagData;
        [SetUp]
        public void SetUp()
        {
            _dbSet = new Mock<DbSet<Post>>();
            data = new List<Post>()
            {
            new Post
                {
                    Id = 1,
                    Title = "Post Title demo:" + 1,
                    ShortDescription = "Post ShortDescription demo:" + 1,
                    PostContent = "Post PostContent demo:" + 1,
                    UrlSlug = "Post UrlSlug demo:" + 1,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 1, 1),
                    Modified = new DateTime(2020, 11, 1),
                    CategoryId = 1,
                    Status=Status.Actived,
                    RateCount=3,
                    TotalRate=2,
                    ViewCount=3,
                },
                new Post
                {
                    Id = 2,
                    Title = "Post Title demo:" + 2,
                    ShortDescription = "Post ShortDescription demo:" + 2,
                    PostContent = "Post PostContent demo:" + 2,
                    UrlSlug = "Post UrlSlug demo:" + 2,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 1, 2),
                    Modified = new DateTime(2020, 11, 2),
                    CategoryId = 1,
                    Status=Status.Actived,
                    RateCount=5,
                    TotalRate=2,
                    ViewCount=3,
                },
                new Post
                {
                    Id = 3,
                    Title = "Post Title demo:" + 3,
                    ShortDescription = "Post ShortDescription demo:" + 3,
                    PostContent = "Post PostContent demo:" + 3,
                    UrlSlug = "Post UrlSlug demo:" + 3,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 1, 3),
                    Modified = new DateTime(2020, 11, 3),
                    CategoryId = 1,
                 Status=Status.Deleted,
                    RateCount=6,
                    TotalRate=4,
                    ViewCount=1,
                },
                new Post
                {
                    Id = 4,
                    Title = "Post Title demo:" + 4,
                    ShortDescription = "Post ShortDescription demo:" + 4,
                    PostContent = "Post PostContent demo:" + 4,
                    UrlSlug = "Post UrlSlug demo:" + 4,
                    Published = Publish.Unpublised,
                    PostedOn = new DateTime(2020, 2, 4),
                    Modified = new DateTime(2020, 11, 4),
                    CategoryId = 2,
                    Status=Status.Actived,
                    RateCount=8,
                    TotalRate=9,
                    ViewCount=9,
                }
            }.AsQueryable();
            _dbSet.As<IQueryable<Post>>().Setup(m => m.Provider).Returns(data.Provider);
            _dbSet.As<IQueryable<Post>>().Setup(m => m.Expression).Returns(data.Expression);
            _dbSet.As<IQueryable<Post>>().Setup(m => m.ElementType).Returns(data.ElementType);
            _dbSet.As<IQueryable<Post>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            _dbPostTagMapSet = new Mock<DbSet<PostTagMap>>();
            postTagMapData = new List<PostTagMap>()
            {
            new PostTagMap { PostId = 1, TagId = 1,Status=Status.Actived },
            new PostTagMap { PostId = 1, TagId = 2,Status=Status.Actived  },
            new PostTagMap { PostId = 1, TagId = 3,Status=Status.Actived  },
            new PostTagMap { PostId = 2, TagId = 1,Status=Status.Actived  },
            new PostTagMap { PostId = 2, TagId = 2 ,Status=Status.Actived },
            new PostTagMap { PostId = 3, TagId = 3 ,Status=Status.Actived },
            new PostTagMap { PostId = 4, TagId = 1 ,Status=Status.Actived }
            }.AsQueryable();
            _dbPostTagMapSet.As<IQueryable<PostTagMap>>().Setup(m => m.Provider).Returns(postTagMapData.Provider);
            _dbPostTagMapSet.As<IQueryable<PostTagMap>>().Setup(m => m.Expression).Returns(postTagMapData.Expression);
            _dbPostTagMapSet.As<IQueryable<PostTagMap>>().Setup(m => m.ElementType).Returns(postTagMapData.ElementType);
            _dbPostTagMapSet.As<IQueryable<PostTagMap>>().Setup(m => m.GetEnumerator()).Returns(postTagMapData.GetEnumerator());

            _dbCategorySet = new Mock<DbSet<Category>>();
            categoryData = new List<Category>()
            {
            new Category
                {
                    Id = 1,
                    Name = "Category Name 1",
                    UrlSlug = "Category UrlSlug 1",
                    Description = "Category Description 1"
                },
                new Category
                {
                    Id = 2,
                    Name = "Category Name 2",
                    UrlSlug = "Category UrlSlug 2",
                    Description = "Category Description 2"
                },
                new Category
                {
                    Id = 3,
                    Name = "Category Name 3",
                    UrlSlug = "Category UrlSlug 3",
                    Description = "Category Description 3"
                    ,Status=Status.Actived
                }
            }.AsQueryable();
            _dbCategorySet.As<IQueryable<Category>>().Setup(m => m.Provider).Returns(categoryData.Provider);
            _dbCategorySet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(categoryData.Expression);
            _dbCategorySet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(categoryData.ElementType);
            _dbCategorySet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(categoryData.GetEnumerator());

            _dbTagSet = new Mock<DbSet<Tag>>();
            tagData = new List<Tag>()
            {
            new Tag
               {
                   Id = 1,
                   Name = "Tag Name demo:" + 1,
                   UrlSlug = "Tag UrlSlug demo:" + 1,
                   Description = "Tag Description demo:" + 1,
                   Count = 1
               },
                new Tag
                {
                    Id = 2,
                    Name = "Tag Name demo:" + 2,
                    UrlSlug = "Tag UrlSlug demo:" + 2,
                    Description = "Tag Description demo:" + 2,
                    Count = 2
                },
                new Tag
                {
                    Id = 3,
                    Name = "Tag Name demo:" + 3,
                    UrlSlug = "Tag UrlSlug demo:" + 3,
                    Description = "Tag Description demo:" + 3,
                    Count = 3
                },
                new Tag
                {
                    Id = 4,
                    Name = "Tag Name demo:" + 4,
                    UrlSlug = "Tag UrlSlug demo:" + 4,
                    Description = "Tag Description demo:" + 4,
                    Count = 4
                },
                new Tag
                {
                    Id = 5,
                    Name = "Tag Name demo:" + 5,
                    UrlSlug = "Tag UrlSlug demo:" + 5,
                    Description = "Tag Description demo:" + 5,
                    Count = 5
                },
                new Tag
                {
                    Id = 6,
                    Name = "Tag Name demo:" + 6,
                    UrlSlug = "Tag UrlSlug demo:" + 6,
                    Description = "Tag Description demo:" + 6,
                    Count = 6
                },
            }.AsQueryable();
            _dbTagSet.As<IQueryable<Tag>>().Setup(m => m.Provider).Returns(tagData.Provider);
            _dbTagSet.As<IQueryable<Tag>>().Setup(m => m.Expression).Returns(tagData.Expression);
            _dbTagSet.As<IQueryable<Tag>>().Setup(m => m.ElementType).Returns(tagData.ElementType);
            _dbTagSet.As<IQueryable<Tag>>().Setup(m => m.GetEnumerator()).Returns(tagData.GetEnumerator());


            _context = new Mock<JustBlogContext>();
            _context.Setup(x => x.Set<Post>()).Returns(_dbSet.Object);
            _context.Setup(x => x.Set<PostTagMap>()).Returns(_dbPostTagMapSet.Object);
            _context.Setup(x => x.Set<Category>()).Returns(_dbCategorySet.Object);
            _context.Setup(x => x.Set<Tag>()).Returns(_dbTagSet.Object);

            _repository = new PostRepository(_context.Object);
        }

        /*
        Because GetById(),Create(),Update(),Delete(),GetAll() is written in BaseRepository
        and already test in 'CategoryRepositoryTests' it will not be tested here
        */

        [Test]
        [TestCase("Category Name 1", 2)]
        [TestCase("Category Name 2", 1)]
        [TestCase("Category Name not exist", 0)]
        public void CountPostsForCategory_WhenCall_ReturnListPost(string category, int expected)
        {
            //Arrange
            //Act
            var actual = _repository.CountPostsForCategory(category);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        [TestCase("Tag Name demo:1", 3)]
        [TestCase("Tag Name demo:2", 2)]
        [TestCase("Tag Name demo:3", 1)]
        [TestCase("Tag Name not exist", 0)]
        public void CountPostsForTag_WhenCall_ReturnListPost(string tag, int expected)
        {
            //Arrange
            //Act
            var actual = _repository.CountPostsForTag(tag);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(2020, 10, "Post UrlSlug demo:4")]
        [TestCase(2020, 10, "Post UrlSlug demo:3")]
        [TestCase(2020, 10, "Post UrlSlug demo:5")]
        public void FindPost_WhenCall_ReturnPost(int year, int month, string urlSlug)
        {
            //Arrange
            var expected = data.FirstOrDefault(t => t.PostedOn.Year == year
                            && t.PostedOn.Month == month
                            && t.UrlSlug == urlSlug
                            && t.Status == Status.Actived
                            );

            //Act
            var actual = _repository.FindPost(year, month, urlSlug);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));

        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void GetLatestPost_WhenCall_ReturnListLatestPost(int size)
        {
            //Arrange
            var expected = data.Where(t => t.Status == Status.Actived).OrderByDescending(t => t.PostedOn).Take(size).ToList();

            //Act
            var actual = _repository.GetLatestPost(size);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));

        }

        [Test]
        [TestCase("Category Name 1")]
        [TestCase("Category Name 2")]
        public void GetPostsByCategory_WhenCall_ReturnListPost(string category)
        {
            //Arrange
            var expected = data.Join(categoryData, p => p.CategoryId, c => c.Id, (p, c) => new { p, c })
                .Where(tb => tb.c.Name == category)
                .Where(tb => tb.p.Status == Status.Actived)
                .Select(tb => tb.p).ToList();

            //Act
            var actual = _repository.GetPostsByCategory(category);

            //Assert
            Assert.That(expected, Is.EqualTo(actual));

        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(12)]
        public void GetPostsByMonth_WhenCall_ReturnListPost(int month)
        {
            //Arrange
            var expected = data.Where(t => t.PostedOn.Month == month
                                        && t.Status==Status.Actived);

            //Act
            var actual = _repository.GetPostsByMonth(new DateTime(2000, month, 1));

            //Assert
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        [TestCase("Tag Name demo:1",3)]
        [TestCase("Tag Name demo:2", 2)]
        [TestCase("Tag Name demo:3", 1)]
        [TestCase("Tag Name not exist", 0)]
        public void GetPostsByTag_WhenCall_ReturnListPost(string tag,int expected)
        {
            //Arrange
            //Act
            var actual = _repository.GetPostsByTag(tag);

            //Assert
            Assert.That(actual.Count(), Is.EqualTo(expected));
        }
        [Test]
        public void GetPublisedPosts_WhenCall_ReturnListPost()
        {
            //Arrange
            var expected = data.Where(t => t.Published==Publish.Publised
                                        && t.Status == Status.Actived);

            //Act
            var actual = _repository.GetPublisedPosts();

            //Assert
            Assert.That(actual, Is.EqualTo(expected));

        }
        [Test]
        public void GetUnublisedPosts_WhenCall_ReturnListPost()
        {
            //Arrange
            var expected = data.Where(t => t.Published == Publish.Unpublised
                                        && t.Status == Status.Actived);

            //Act
            var actual = _repository.GetUnpublisedPosts();

            //Assert
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void GetMostViewedPost_WhenCall_ReturnListPost(int size)
        {
            //Arrange
            var expected = data.Where(t => t.Status == Status.Actived)
                .OrderByDescending(t => t.ViewCount).Take(size).ToList();

            //Act
            var actual = _repository.GetMostViewedPost(size);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void GetHighestPosts_WhenCall_ReturnListPost(int size)
        {
            //Arrange
            var expected = data.Where(t => t.Status == Status.Actived)
                .OrderByDescending(t => t.Rate).Take(size).ToList();

            //Act
            var actual = _repository.GetHighestPosts(size);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));

        }
    }
}
