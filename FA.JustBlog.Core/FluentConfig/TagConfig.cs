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
    /// Fluent Config of Tag
    /// </summary>
    public class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(t =>t.Id );
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Name).HasMaxLength(255);

            builder.Property(t => t.UrlSlug).HasMaxLength(255);
            builder.Property(t => t.Description).HasMaxLength(1024);

            builder.Property(t => t.CreateAt).HasDefaultValueSql("getdate()");
            builder.Property(t => t.UpdateAt).HasDefaultValueSql("getdate()");
            builder.Property(t => t.Status).HasDefaultValue(Status.Actived);
        }
    }
}
