using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.FluentConfig
{
    /// <summary>
    /// Fluent Config of Post
    /// </summary>
    public class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Title).IsRequired();
            builder.Property(t => t.Title).HasMaxLength(255);

            builder.Property(t => t.UrlSlug).HasMaxLength(255);

            builder.Property(t => t.Published).HasDefaultValue(Publish.Publised);

            builder.Property(t => t.CreateAt).HasDefaultValueSql("getdate()");
            builder.Property(t => t.UpdateAt).HasDefaultValueSql("getdate()");
            builder.Property(t => t.Status).HasDefaultValue(Status.Actived);

            builder.HasOne(t => t.Category).WithMany(t => t.Posts).HasForeignKey(t => t.CategoryId).OnDelete(DeleteBehavior.ClientCascade);

        }
    }
}
