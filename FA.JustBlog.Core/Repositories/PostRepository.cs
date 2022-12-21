using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;


namespace FA.JustBlog.Core.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        protected DbSet<Category> CategoryDbSet;
        protected DbSet<Tag> TagDbSet;
        protected DbSet<PostTagMap> PostTagMapDbSet;
        public PostRepository(JustBlogContext context) : base(context)
        {
            CategoryDbSet = context.Set<Category>();
            TagDbSet = context.Set<Tag>();
            PostTagMapDbSet = context.Set<PostTagMap>();
        }

        public int CountPostsForCategory(string category)
        {
            return (from post in DbSet
                    join cate in CategoryDbSet on post.CategoryId equals cate.Id
                    where cate.Name == category
                    where post.Status == Status.Actived
                    select post).Count();
        }

        public int CountPostsForTag(string tag)
        {
            return (from post in DbSet
                    join postTag in PostTagMapDbSet on post.Id equals postTag.PostId
                    join tog in TagDbSet on postTag.TagId equals tog.Id
                    where tog.Name == tag
                    where post.Status == Status.Actived
                    select post).Count();
        }

        public Post FindPost(int year, int month, string urlSlug)
        {
            return Find(t => t.PostedOn.Year == year
                            && t.PostedOn.Month == month
                            && t.UrlSlug == urlSlug)
                    .FirstOrDefault();
        }

        public IList<Post> GetHighestPosts(int size)
        {
            return DbSet.Where(t => t.Status == Status.Actived)
                .OrderByDescending(t => t.Rate).Take(size).ToList();
        }

        public IList<Post> GetLatestPost(int size)
        {
            return DbSet.Where(t=>t.Status==Status.Actived)
                .OrderByDescending(t => t.PostedOn).Take(size).ToList();
        }

        public IList<Post> GetMostViewedPost(int size)
        {
            return DbSet.Where(t => t.Status == Status.Actived)
                .OrderByDescending(t => t.ViewCount).Take(size).ToList();
        }

        public IList<Post> GetPostsByCategory(string category)
        {
            var innerJoinQuery =
              from post in DbSet
              join cate in CategoryDbSet on post.CategoryId equals cate.Id
              where cate.Name == category
              where post.Status == Status.Actived
              select post;
            return innerJoinQuery.ToList();
        }

        public IList<Post> GetPostsByMonth(DateTime monthYear)
        {
            return Find(t => t.PostedOn.Month == monthYear.Month).ToList();
        }

        public IList<Post> GetPostsByTag(string tag)
        {
            var innerJoinQuery =
              from post in DbSet
              join postTag in PostTagMapDbSet on post.Id equals postTag.PostId
              join tog in TagDbSet on postTag.TagId equals tog.Id
              where tog.Name == tag
              where post.Status == Status.Actived
              select post;
            return innerJoinQuery.ToList();

        }

        public IList<Post> GetPublisedPosts()
        {
            return Find(t => t.Published == Publish.Publised).ToList();
        }

        public IList<Post> GetUnpublisedPosts()
        {
            return Find(t => t.Published == Publish.Unpublised).ToList();
        }
    }
}
