using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Data
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            builder.HasData(
                new IdentityUser
                {
                    Id = "dd10f17b-6c30-43c8-b326-c69a807ba2c5",
                    Email = "thanhs1@user.com",
                    NormalizedEmail = "THANHS1@USER.COM",
                    UserName = "thanhs1@user.com",
                    NormalizedUserName = "THANHS1@USER.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                },
                new IdentityUser
                {
                    Id = "5c286ddc-e0fd-4a35-bada-c33ba1dc90ed",
                    Email = "thanhs2@user.com",
                    NormalizedEmail = "THANHS2@USER.COM",
                    UserName = "thanhs2@user.com",
                    NormalizedUserName = "THANHS2@USER.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                },
                new IdentityUser
                {
                    Id = "29a1edd8-8a04-4ad4-9cc3-a0402f533017",
                    Email = "thanhs3@user.com",
                    NormalizedEmail = "THANHS3@USER.COM",
                    UserName = "thanhs3@user.com",
                    NormalizedUserName = "THANHS3@USER.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                },
                
                
                new IdentityUser
                {
                    Id = "7d1cb70a-6c6f-4920-b353-30f5a97e9767",
                    Email = "thanhc2@contributor.com",
                    NormalizedEmail = "THANHC2@CONTRIBUTOR.COM",
                    UserName = "thanhc2@contributor.com",
                    NormalizedUserName = "THANHC2@CONTRIBUTOR.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                },
                new IdentityUser
                {
                    Id = "e6e01470-3dcd-41b3-9eac-b11cdc461330",
                    Email = "thanhc3@contributor.com",
                    NormalizedEmail = "THANHC3@CONTRIBUTOR.COM",
                    UserName = "thanhc3@contributor.com",
                    NormalizedUserName = "THANHC3@CONTRIBUTOR.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                }, 
                new IdentityUser
                {
                    Id = "a2d6f7a5-7249-407c-8518-effb9df83f4d",
                    Email = "thanhc1@contributor.com",
                    NormalizedEmail = "THANHC1@CONTRIBUTOR.COM",
                    UserName = "thanhc1@contributor.com",
                    NormalizedUserName = "THANHC1@CONTRIBUTOR.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                },


                new IdentityUser
                {
                    Id = "350a7ff5-dddc-4642-b377-52bfb6ad30e8",
                    Email = "thanhb1@blogOwner.com",
                    NormalizedEmail = "THANHB1@BLOGOWNER.COM",
                    UserName = "thanhb1@blogOwner.com",
                    NormalizedUserName = "THANHB1@BLOGOWNER.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                },
                new IdentityUser
                {
                    Id = "9f09f22c-2b9a-4899-90bf-9772e03edb55",
                    Email = "thanhb2@blogOwner.com",
                    NormalizedEmail = "THANHB2@BLOGOWNER.COM",
                    UserName = "thanhb2@blogOwner.com",
                    NormalizedUserName = "THANHB2@BLOGOWNER.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                },
                new IdentityUser
                {
                    Id = "e99efd43-0141-4f63-bae0-c4b1a772fbf4",
                    Email = "thanhb3@blogOwner.com",
                    NormalizedEmail = "THANHB3@BLOGOWNER.COM",
                    UserName = "thanhb3@blogOwner.com",
                    NormalizedUserName = "THANHB3@BLOGOWNER.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                }
                
                );
        }
    }
}
