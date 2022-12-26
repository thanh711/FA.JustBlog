using FA.JustBlog.Core.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Data
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "12fc2c0e-99bf-447d-9b4d-45996a250f16",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "0e01b5da-60a1-426e-b306-edbecd1aa228",
                    Name = Roles.Contributor,
                    NormalizedName = Roles.Contributor.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "d6039682-54c4-434a-920a-d91b3888d18d",
                    Name = Roles.BlogOwner,
                    NormalizedName = Roles.BlogOwner.ToUpper(),
                }
                );
        }
    }
}
