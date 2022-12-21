using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FA.JustBlog.Core.Enum;

namespace FA.JustBlog.Core.FluentConfig
{
    /// <summary>
    /// Fluent Config of PostTagMap
    /// </summary>
    public class PostTagMapConfig : IEntityTypeConfiguration<PostTagMap>
    {
        public void Configure(EntityTypeBuilder<PostTagMap> builder)
        {
            builder.HasKey(t => new { t.TagId, t.PostId });

            builder.HasOne(t => t.Post).WithMany(t => t.PostTagMaps).HasForeignKey(t => t.PostId);
            builder.HasOne(t => t.Tag).WithMany(t => t.PostTagMaps).HasForeignKey(t => t.TagId);

            builder.Property(t => t.CreateAt).HasDefaultValueSql("getdate()");
            builder.Ignore(t => t.UpdateAt);
            builder.Property(t => t.Status).HasDefaultValue(Status.Actived);

        }
    }
}

