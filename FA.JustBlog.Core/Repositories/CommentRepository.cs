using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(JustBlogContext context) : base(context)
        {
        }

        public void AddComment(int postId, string commentName, string commentEmail, string commentTitle, string commentBody)
        {
            Create(new Comment
            {
                Name = commentName,
                Email = commentEmail,
                CommentHeader = commentTitle,
                CommentText = commentBody,
                PostId = postId,
                CommentTime = DateTime.Now
            });
        }

        public IList<Comment> GetCommentsForPost(int postId)
        {
            return Find(t=>t.PostId==postId).ToList();
        }

        public IList<Comment> GetCommentsForPost(Post post)
        {
            return GetCommentsForPost(post.Id);
        }
    }
}
