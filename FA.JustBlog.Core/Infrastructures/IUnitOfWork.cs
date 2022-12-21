using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Infrastructures
{
    public interface IUnitOfWork : IDisposable
    {
        public ICategoryRepository CategoryRepository { get; } 
        public ICommentRepository CommentRepository { get; }
        public IPostRepository PostRepository { get; }
        public ITagRepository TagRepository { get; }

        public JustBlogContext JustBlogContext { get; }
        int SaveChanges();
    }
}
