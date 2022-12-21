using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JustBlogContext _context=new();
        private ICategoryRepository categoryRepository;

        public ICategoryRepository CategoryRepository
        {
            get { return categoryRepository?? (categoryRepository=new CategoryRepository(_context)); }
        }

        private ICommentRepository commentRepository;

        public ICommentRepository CommentRepository
        {
            get { return commentRepository ?? (commentRepository = new CommentRepository(_context)); }
        }
        private IPostRepository postRepository;

        public IPostRepository PostRepository
        {
            get { return postRepository ?? (postRepository = new PostRepository(_context)); }
        }

        private ITagRepository tagRepository;

        public ITagRepository TagRepository
        {
            get { return tagRepository ?? (tagRepository = new TagRepository(_context)); }
        }

        public JustBlogContext JustBlogContext => _context;

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
