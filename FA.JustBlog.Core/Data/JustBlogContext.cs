using FA.JustBlog.Core.FluentConfig;
using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Data
{
    public class JustBlogContext : DbContext
    {
        public JustBlogContext()
        {
        }

        public JustBlogContext(DbContextOptions<JustBlogContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTagMap> PostTagMaps { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=THANHNC0711;Database=JustBlog;Integrated security=True;Encrypt=false";
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostTagMapConfig).Assembly);

            modelBuilder.Seed();
        }
    }
}
