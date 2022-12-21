using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.IRepositories
{
    /// <summary>
    /// Post repository implement some basic CRUD functions
    /// </summary>
    public interface IPostRepository : IBaseRepository<Post>
    {
        Post FindPost(int year, int month, string urlSlug);
        IList<Post> GetPublisedPosts();
        IList<Post> GetUnpublisedPosts();
        IList<Post> GetLatestPost(int size);
        IList<Post> GetPostsByMonth(DateTime monthYear);
        int CountPostsForCategory(string category);
        IList<Post> GetPostsByCategory(string category);
        int CountPostsForTag(string tag);
        IList<Post> GetPostsByTag(string tag);

        IList<Post> GetMostViewedPost(int size);
        IList<Post> GetHighestPosts(int size);
    }
}
