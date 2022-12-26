using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class InitUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 32, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 34, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 36, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 48, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 49, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 38, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 48, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 49, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 36, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 38, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 48, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 34, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 28, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 34, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 36, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 27, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 45, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 48, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 40, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 46, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 49, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 17, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 22, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 28, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 40, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 44, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 46, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 33, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 46, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 48, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 24, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 28, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 35, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 39, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 44, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 45, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 32, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 36, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 8, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 16, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 30, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 36, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 14 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e01b5da-60a1-426e-b306-edbecd1aa228", "99f8340c-b829-40f6-8994-e318aea1e78c", "Contributor", "CONTRIBUTOR" },
                    { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "0f66d418-0b01-4bc9-9c8c-55688aad4086", "User", "USER" },
                    { "d6039682-54c4-434a-920a-d91b3888d18d", "59509ff5-1968-4d56-9111-7db964ad9cea", "BlogOwner", "BLOGOWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "29a1edd8-8a04-4ad4-9cc3-a0402f533017", 0, "5de86cbb-383e-4c0c-bb1b-544a87949f1f", "thanhs3@user.com", true, false, null, "THANHS3@USER.COM", "THANHS3@USER.COM", "AQAAAAEAACcQAAAAECfwYDigeTttUbysQOdkkDxJiODwCewN2mLOTSdyiYASj3VvDG9eTWuWXXuaeAWyQQ==", null, false, "c26f7001-4a03-4316-b1dc-2ed2c1a7e092", false, "thanhs3@user.com" },
                    { "350a7ff5-dddc-4642-b377-52bfb6ad30e8", 0, "56fc213b-3138-43e6-9a5c-79bd1f1ce12c", "thanhb1@blogOwner.com", true, false, null, "THANHB1@BLOGOWNER.COM", "THANHB1@BLOGOWNER.COM", "AQAAAAEAACcQAAAAEGSv4IZ0f6Yd8QJUT1eJ+7cStpHxFcuLEA7BBBqHqgE88M5AUUh94Im87aW/bH31qA==", null, false, "3f0e7965-438a-4586-a0b0-fb576d3287dc", false, "thanhb1@blogOwner.com" },
                    { "5c286ddc-e0fd-4a35-bada-c33ba1dc90ed", 0, "4e711efb-37b9-414e-8119-6030ff40952f", "thanhs2@user.com", true, false, null, "THANHS2@USER.COM", "THANHS2@USER.COM", "AQAAAAEAACcQAAAAEMrCoJzpobMnK+urSLhKU7O/swyioNoVG8rDerYNM/T0nuhRmJpd2GIsA48FCqNR7w==", null, false, "bd7011b5-08ee-4e53-a22a-6a429748aa98", false, "thanhs2@user.com" },
                    { "7d1cb70a-6c6f-4920-b353-30f5a97e9767", 0, "919eb6bf-a5b7-4a89-9476-c9e59eeba085", "thanhc2@contributor.com", true, false, null, "THANHC2@CONTRIBUTOR.COM", "THANHC2@CONTRIBUTOR.COM", "AQAAAAEAACcQAAAAEHB80ZZNIC6UICMcyVUXkxXEa1tyMutf/9U5q38bylgcthjFvB5qwdjmFJPzY3Gu3w==", null, false, "811e298c-ad69-428f-8df6-6e1d7b0e3e28", false, "thanhc2@contributor.com" },
                    { "9f09f22c-2b9a-4899-90bf-9772e03edb55", 0, "a73553d0-f9ba-4cdf-9f5f-b75a78f8c097", "thanhb2@blogOwner.com", true, false, null, "THANHB2@BLOGOWNER.COM", "THANHB2@BLOGOWNER.COM", "AQAAAAEAACcQAAAAEPlZ0KScK+k/tgGsS+HIyIAy5n8/FvvjrpOnN5C+6WmAD3Jt63epp6zQO51CnT9xOA==", null, false, "4a645c4e-9944-4248-aaa2-20e003a9cd33", false, "thanhb2@blogOwner.com" },
                    { "a2d6f7a5-7249-407c-8518-effb9df83f4d", 0, "98e65832-6f11-42ac-ae60-7495f29f9b67", "thanhc1@contributor.com", true, false, null, "THANHC1@CONTRIBUTOR.COM", "THANHC1@CONTRIBUTOR.COM", "AQAAAAEAACcQAAAAEECMCkafSWEN6vKSxTaxj143pMWRoGuXRDfYSXuT4XaqvpLx65dtQZqvF9NhktnoWg==", null, false, "ac7c5799-b0d0-4d76-844b-658f2761f62a", false, "thanhc1@contributor.com" },
                    { "dd10f17b-6c30-43c8-b326-c69a807ba2c5", 0, "7b9c4918-35d1-4ade-a4ae-6ba0484db81b", "thanhs1@user.com", true, false, null, "THANHS1@USER.COM", "THANHS1@USER.COM", "AQAAAAEAACcQAAAAEGoxLv99cLjk1ZgUyjH0iciPiiyg2bcUv+AHN305OvW8XNTaadbqibvmfIjPdYtdeA==", null, false, "703e520c-fc90-4e03-860b-7d91f11381b0", false, "thanhs1@user.com" },
                    { "e6e01470-3dcd-41b3-9eac-b11cdc461330", 0, "af896ee4-7571-430b-bddf-bf7dd64ee606", "thanhc3@contributor.com", true, false, null, "THANHC3@CONTRIBUTOR.COM", "THANHC3@CONTRIBUTOR.COM", "AQAAAAEAACcQAAAAEFTv1nZWguTU4icNQs98F5/+9RVbcnHCXgdDonsiWBSK02nzO8KmJtqTS+opOpWNnw==", null, false, "32b52f0e-8e69-4803-aa40-02b2a4b2996c", false, "thanhc3@contributor.com" },
                    { "e99efd43-0141-4f63-bae0-c4b1a772fbf4", 0, "d5f2c8c6-7cb0-4d73-8d74-9f21f8339ec2", "thanhb3@blogOwner.com", true, false, null, "THANHB3@BLOGOWNER.COM", "THANHB3@BLOGOWNER.COM", "AQAAAAEAACcQAAAAEE2UFbE0RNrIlIKBbUAgTOPujQEzI87zQcEfSK9DwE3G+qWkqyKXUctP3GQ06Et/Dw==", null, false, "6237433a-2237-4770-b5d3-e7298fcb43de", false, "thanhb3@blogOwner.com" }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3870), 19 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3875), 28 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3876), 27 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3878), 21 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3880), 29 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3882), 20 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3884), 48 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3886), 18 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3919), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3923), 29 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CommentTime",
                value: new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3927), 29 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3928), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3930), 21 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3932), 28 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3933), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3935), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3938), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 35, 9, 50, DateTimeKind.Local).AddTicks(3940), 14 });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 12, 1 },
                    { 13, 1 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 1 },
                    { 29, 1 },
                    { 33, 1 },
                    { 38, 1 },
                    { 43, 1 },
                    { 44, 1 },
                    { 49, 1 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 17, 2 },
                    { 26, 2 },
                    { 27, 2 },
                    { 39, 2 },
                    { 6, 3 },
                    { 21, 3 },
                    { 24, 3 },
                    { 30, 3 },
                    { 37, 3 },
                    { 45, 3 },
                    { 14, 4 },
                    { 37, 4 },
                    { 42, 4 },
                    { 5, 5 },
                    { 18, 5 },
                    { 25, 5 },
                    { 30, 5 },
                    { 38, 5 },
                    { 45, 5 },
                    { 6, 6 },
                    { 7, 6 },
                    { 18, 6 },
                    { 23, 6 },
                    { 25, 6 },
                    { 27, 6 },
                    { 37, 6 },
                    { 45, 6 },
                    { 47, 6 },
                    { 4, 7 },
                    { 10, 7 },
                    { 15, 7 },
                    { 17, 7 },
                    { 33, 7 },
                    { 34, 7 },
                    { 36, 7 },
                    { 41, 7 },
                    { 47, 7 },
                    { 9, 8 },
                    { 13, 8 },
                    { 14, 8 },
                    { 16, 8 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 17, 8 },
                    { 26, 8 },
                    { 30, 8 },
                    { 35, 8 },
                    { 38, 8 },
                    { 47, 8 },
                    { 2, 9 },
                    { 3, 9 },
                    { 14, 9 },
                    { 15, 9 },
                    { 23, 9 },
                    { 24, 9 },
                    { 25, 9 },
                    { 30, 9 },
                    { 36, 9 },
                    { 39, 9 },
                    { 10, 10 },
                    { 13, 10 },
                    { 16, 10 },
                    { 19, 10 },
                    { 22, 10 },
                    { 26, 10 },
                    { 29, 10 },
                    { 38, 10 },
                    { 40, 10 },
                    { 44, 10 },
                    { 6, 11 },
                    { 9, 11 },
                    { 10, 11 },
                    { 18, 11 },
                    { 19, 11 },
                    { 24, 11 },
                    { 25, 11 },
                    { 26, 11 },
                    { 32, 11 },
                    { 37, 11 },
                    { 38, 11 },
                    { 43, 11 },
                    { 45, 11 },
                    { 4, 12 },
                    { 13, 12 },
                    { 14, 12 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 16, 12 },
                    { 20, 12 },
                    { 23, 12 },
                    { 26, 12 },
                    { 31, 12 },
                    { 33, 12 },
                    { 37, 12 },
                    { 38, 12 },
                    { 42, 12 },
                    { 49, 12 },
                    { 1, 13 },
                    { 11, 13 },
                    { 18, 13 },
                    { 29, 13 },
                    { 33, 13 },
                    { 37, 13 },
                    { 41, 13 },
                    { 42, 13 },
                    { 43, 13 },
                    { 10, 14 },
                    { 11, 14 },
                    { 19, 14 },
                    { 24, 14 },
                    { 49, 14 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, 5, 11, 98 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, 21, 34, 24 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, 49, 33, 29 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, 46, 95, 26 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, 7, 21, 10 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2009, 5, 18, 19, 38, 45, 0, DateTimeKind.Unspecified), 90, 34, 16 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2001, 10, 22, 23, 57, 54, 0, DateTimeKind.Unspecified), 43, 199, 95 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2011, 4, 27, 20, 53, 0, 0, DateTimeKind.Unspecified), 15, 137, 78 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2013, 6, 5, 0, 32, 38, 0, DateTimeKind.Unspecified), 88, 5, 76 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2021, 9, 26, 23, 0, 16, 0, DateTimeKind.Unspecified), 13, 22, 52 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2019, 11, 22, 14, 36, 4, 0, DateTimeKind.Unspecified), 49, 115, 75 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2022, 7, 28, 23, 20, 38, 0, DateTimeKind.Unspecified), 40, 22, 8 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2021, 3, 8, 5, 45, 16, 0, DateTimeKind.Unspecified), 55, 88, 20 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2001, 12, 22, 8, 51, 1, 0, DateTimeKind.Unspecified), 63, 135, 35 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "ViewCount" },
                values: new object[] { 7, new DateTime(2004, 3, 19, 22, 30, 36, 0, DateTimeKind.Unspecified), 90, 96 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2005, 9, 10, 18, 26, 10, 0, DateTimeKind.Unspecified), 33, 18, 23 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2016, 9, 23, 6, 55, 28, 0, DateTimeKind.Unspecified), 87, 155, 57 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2003, 9, 28, 1, 34, 56, 0, DateTimeKind.Unspecified), 47, 84, 30 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2020, 5, 10, 15, 23, 56, 0, DateTimeKind.Unspecified), 61, 52, 74 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2020, 10, 9, 12, 38, 9, 0, DateTimeKind.Unspecified), 74, 45, 97 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2008, 11, 7, 7, 43, 13, 0, DateTimeKind.Unspecified), 81, 189, 24 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2021, 4, 22, 3, 0, 46, 0, DateTimeKind.Unspecified), 69, 29, 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2018, 9, 19, 0, 44, 36, 0, DateTimeKind.Unspecified), 59, 186, 24 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2006, 5, 9, 23, 25, 0, 0, DateTimeKind.Unspecified), 97, 109, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2000, 9, 4, 20, 10, 16, 0, DateTimeKind.Unspecified), 4, 13, 68 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2016, 5, 29, 6, 24, 45, 0, DateTimeKind.Unspecified), 69, 187, 95 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2002, 9, 5, 15, 17, 40, 0, DateTimeKind.Unspecified), 71, 125, 13 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2015, 12, 21, 8, 35, 19, 0, DateTimeKind.Unspecified), 23, 39, 36 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2022, 6, 7, 20, 38, 53, 0, DateTimeKind.Unspecified), 3, 75, 67 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 28, 22, 52, 57, 0, DateTimeKind.Unspecified), 75, 72, 47 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2015, 5, 6, 16, 46, 21, 0, DateTimeKind.Unspecified), 79, 167, 30 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2011, 8, 7, 4, 45, 47, 0, DateTimeKind.Unspecified), 4, 63, 26 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2019, 7, 18, 13, 44, 49, 0, DateTimeKind.Unspecified), 99, 82, 55 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2005, 5, 15, 1, 2, 20, 0, DateTimeKind.Unspecified), 4, 160, 55 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2001, 12, 6, 3, 17, 55, 0, DateTimeKind.Unspecified), 15, 19, 8 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2011, 6, 9, 6, 1, 47, 0, DateTimeKind.Unspecified), 56, 159, 22 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2014, 10, 13, 1, 30, 42, 0, DateTimeKind.Unspecified), 86, 119, 72 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2016, 2, 29, 20, 24, 14, 0, DateTimeKind.Unspecified), 98, 153, 54 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2017, 1, 2, 12, 26, 57, 0, DateTimeKind.Unspecified), 56, 168, 23 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2014, 8, 12, 16, 32, 33, 0, DateTimeKind.Unspecified), 23, 71, 65 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2017, 10, 29, 22, 25, 12, 0, DateTimeKind.Unspecified), 85, 186, 81 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2000, 12, 31, 21, 0, 28, 0, DateTimeKind.Unspecified), 54, 110, 97 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2003, 8, 12, 4, 39, 44, 0, DateTimeKind.Unspecified), 64, 167, 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2001, 4, 16, 2, 46, 31, 0, DateTimeKind.Unspecified), 15, 96, 91 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2008, 9, 20, 3, 31, 37, 0, DateTimeKind.Unspecified), 93, 162, 47 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2002, 12, 18, 13, 47, 12, 0, DateTimeKind.Unspecified), 26, 20, 98 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2016, 11, 19, 18, 17, 52, 0, DateTimeKind.Unspecified), 68, 7, 20 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2011, 1, 5, 12, 58, 4, 0, DateTimeKind.Unspecified), 75, 71, 88 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2021, 8, 18, 1, 29, 27, 0, DateTimeKind.Unspecified), 76, 52, 82 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2008, 7, 5, 2, 45, 24, 0, DateTimeKind.Unspecified), 48, 91, 55 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2021, 5, 15, 19, 27, 41, 0, DateTimeKind.Unspecified), 4, 126, 26 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2003, 10, 29, 0, 39, 2, 0, DateTimeKind.Unspecified), 26, 122, 10 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2005, 3, 24, 11, 49, 14, 0, DateTimeKind.Unspecified), 90, 136, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2006, 5, 26, 2, 16, 8, 0, DateTimeKind.Unspecified), 21, 21, 79 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "29a1edd8-8a04-4ad4-9cc3-a0402f533017" },
                    { "d6039682-54c4-434a-920a-d91b3888d18d", "350a7ff5-dddc-4642-b377-52bfb6ad30e8" },
                    { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "5c286ddc-e0fd-4a35-bada-c33ba1dc90ed" },
                    { "0e01b5da-60a1-426e-b306-edbecd1aa228", "7d1cb70a-6c6f-4920-b353-30f5a97e9767" },
                    { "d6039682-54c4-434a-920a-d91b3888d18d", "9f09f22c-2b9a-4899-90bf-9772e03edb55" },
                    { "0e01b5da-60a1-426e-b306-edbecd1aa228", "a2d6f7a5-7249-407c-8518-effb9df83f4d" },
                    { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "dd10f17b-6c30-43c8-b326-c69a807ba2c5" },
                    { "0e01b5da-60a1-426e-b306-edbecd1aa228", "e6e01470-3dcd-41b3-9eac-b11cdc461330" },
                    { "d6039682-54c4-434a-920a-d91b3888d18d", "e99efd43-0141-4f63-bae0-c4b1a772fbf4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "29a1edd8-8a04-4ad4-9cc3-a0402f533017" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6039682-54c4-434a-920a-d91b3888d18d", "350a7ff5-dddc-4642-b377-52bfb6ad30e8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "5c286ddc-e0fd-4a35-bada-c33ba1dc90ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e01b5da-60a1-426e-b306-edbecd1aa228", "7d1cb70a-6c6f-4920-b353-30f5a97e9767" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6039682-54c4-434a-920a-d91b3888d18d", "9f09f22c-2b9a-4899-90bf-9772e03edb55" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e01b5da-60a1-426e-b306-edbecd1aa228", "a2d6f7a5-7249-407c-8518-effb9df83f4d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "12fc2c0e-99bf-447d-9b4d-45996a250f16", "dd10f17b-6c30-43c8-b326-c69a807ba2c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e01b5da-60a1-426e-b306-edbecd1aa228", "e6e01470-3dcd-41b3-9eac-b11cdc461330" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6039682-54c4-434a-920a-d91b3888d18d", "e99efd43-0141-4f63-bae0-c4b1a772fbf4" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 39, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 21, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 37, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 45, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 37, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 42, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 45, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 23, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 27, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 37, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 45, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 47, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 33, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 36, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 47, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 26, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 30, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 35, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 38, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 47, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 23, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 24, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 30, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 36, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 39, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 19, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 22, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 26, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 38, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 40, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 44, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 19, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 24, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 26, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 32, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 37, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 38, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 45, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 16, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 20, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 23, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 26, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 31, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 33, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 37, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 38, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 42, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 49, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 33, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 37, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 42, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 11, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 19, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 24, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 49, 14 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e01b5da-60a1-426e-b306-edbecd1aa228");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12fc2c0e-99bf-447d-9b4d-45996a250f16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6039682-54c4-434a-920a-d91b3888d18d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29a1edd8-8a04-4ad4-9cc3-a0402f533017");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "350a7ff5-dddc-4642-b377-52bfb6ad30e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c286ddc-e0fd-4a35-bada-c33ba1dc90ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d1cb70a-6c6f-4920-b353-30f5a97e9767");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f09f22c-2b9a-4899-90bf-9772e03edb55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d6f7a5-7249-407c-8518-effb9df83f4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd10f17b-6c30-43c8-b326-c69a807ba2c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6e01470-3dcd-41b3-9eac-b11cdc461330");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e99efd43-0141-4f63-bae0-c4b1a772fbf4");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8193), 17 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8198), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8200), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8202), 35 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8203), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8247), 47 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8249), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8250), 33 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8252), 17 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8256), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CommentTime",
                value: new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8259), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8261), 34 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8263), 38 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8264), 44 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8266), 16 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8268), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8271), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CommentTime", "PostId" },
                values: new object[] { new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8273), 15 });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId", "CreateAt", "Status" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 15, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 22, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 25, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 30, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 36, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 11, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 25, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 28, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 32, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 34, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 36, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 45, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 48, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 49, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId", "CreateAt", "Status" },
                values: new object[,]
                {
                    { 15, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 17, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 29, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 38, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 48, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 49, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 19, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 20, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 22, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 27, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 36, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 38, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 41, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 48, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 22, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 27, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 29, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 34, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 24, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 28, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 34, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 36, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 41, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 11, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 14, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 21, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 25, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 27, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 45, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 48, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 1, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 15, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId", "CreateAt", "Status" },
                values: new object[,]
                {
                    { 20, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 29, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 40, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 46, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 49, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 10, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 16, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 17, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 22, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 28, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 40, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 41, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 43, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 44, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 46, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 14, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 25, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 33, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 41, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 14, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 15, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 41, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 46, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 48, 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 24, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 28, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 35, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 39, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 44, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 45, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId", "CreateAt", "Status" },
                values: new object[,]
                {
                    { 14, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 16, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 25, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 32, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 36, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 15, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 16, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 30, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 36, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 43, 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, 75, 118, 67 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, 55, 104, 73 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, 57, 118, 58 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, 33, 127, 40 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, 11, 9, 45 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2003, 8, 8, 2, 29, 36, 0, DateTimeKind.Unspecified), 5, 173, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2019, 11, 10, 18, 45, 54, 0, DateTimeKind.Unspecified), 84, 175, 21 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2012, 7, 21, 9, 22, 46, 0, DateTimeKind.Unspecified), 51, 172, 49 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2009, 7, 30, 3, 38, 12, 0, DateTimeKind.Unspecified), 39, 117, 98 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2002, 3, 16, 12, 37, 4, 0, DateTimeKind.Unspecified), 2, 136, 69 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2007, 1, 25, 22, 28, 33, 0, DateTimeKind.Unspecified), 92, 124, 18 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2008, 8, 5, 21, 8, 40, 0, DateTimeKind.Unspecified), 15, 119, 94 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2016, 10, 24, 20, 45, 2, 0, DateTimeKind.Unspecified), 18, 9, 29 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2002, 10, 16, 6, 51, 27, 0, DateTimeKind.Unspecified), 6, 25, 29 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "ViewCount" },
                values: new object[] { 5, new DateTime(2005, 8, 26, 22, 0, 47, 0, DateTimeKind.Unspecified), 24, 38 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2002, 11, 13, 1, 12, 16, 0, DateTimeKind.Unspecified), 96, 126, 39 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2007, 4, 2, 15, 19, 55, 0, DateTimeKind.Unspecified), 75, 158, 61 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2019, 2, 20, 5, 47, 17, 0, DateTimeKind.Unspecified), 54, 45, 89 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2010, 7, 7, 6, 42, 19, 0, DateTimeKind.Unspecified), 84, 58, 8 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2005, 4, 23, 23, 18, 25, 0, DateTimeKind.Unspecified), 92, 160, 23 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2020, 1, 7, 16, 50, 2, 0, DateTimeKind.Unspecified), 54, 24, 57 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2004, 12, 23, 19, 7, 53, 0, DateTimeKind.Unspecified), 32, 24, 22 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2015, 1, 12, 2, 32, 14, 0, DateTimeKind.Unspecified), 55, 128, 20 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2006, 4, 1, 9, 49, 34, 0, DateTimeKind.Unspecified), 64, 39, 63 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2017, 6, 6, 2, 13, 18, 0, DateTimeKind.Unspecified), 89, 86, 83 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2010, 12, 6, 6, 59, 22, 0, DateTimeKind.Unspecified), 25, 170, 99 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2018, 2, 16, 3, 31, 42, 0, DateTimeKind.Unspecified), 64, 85, 97 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2000, 2, 12, 8, 46, 18, 0, DateTimeKind.Unspecified), 90, 109, 83 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2014, 7, 12, 12, 42, 26, 0, DateTimeKind.Unspecified), 93, 126, 25 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2000, 12, 11, 6, 45, 35, 0, DateTimeKind.Unspecified), 54, 119, 54 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2020, 6, 13, 12, 6, 17, 0, DateTimeKind.Unspecified), 9, 31, 43 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2004, 7, 24, 8, 35, 27, 0, DateTimeKind.Unspecified), 92, 151, 31 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2011, 2, 23, 22, 25, 48, 0, DateTimeKind.Unspecified), 28, 187, 52 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2009, 2, 8, 21, 54, 56, 0, DateTimeKind.Unspecified), 20, 127, 51 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2020, 4, 5, 9, 57, 31, 0, DateTimeKind.Unspecified), 19, 181, 36 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2022, 6, 21, 22, 36, 15, 0, DateTimeKind.Unspecified), 24, 36, 59 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2010, 2, 12, 22, 43, 6, 0, DateTimeKind.Unspecified), 57, 195, 85 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2011, 6, 16, 7, 52, 6, 0, DateTimeKind.Unspecified), 50, 160, 56 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2021, 11, 7, 2, 15, 19, 0, DateTimeKind.Unspecified), 13, 50, 71 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2004, 4, 15, 10, 13, 8, 0, DateTimeKind.Unspecified), 94, 88, 57 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2019, 11, 2, 3, 35, 44, 0, DateTimeKind.Unspecified), 64, 93, 97 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2021, 6, 25, 14, 16, 38, 0, DateTimeKind.Unspecified), 56, 27, 60 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2015, 10, 13, 5, 25, 43, 0, DateTimeKind.Unspecified), 75, 136, 73 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2009, 6, 7, 13, 39, 16, 0, DateTimeKind.Unspecified), 82, 68, 28 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2016, 5, 25, 14, 8, 55, 0, DateTimeKind.Unspecified), 27, 160, 21 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2016, 12, 1, 3, 14, 50, 0, DateTimeKind.Unspecified), 66, 46, 69 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2003, 12, 30, 1, 9, 17, 0, DateTimeKind.Unspecified), 77, 144, 34 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2019, 4, 19, 8, 10, 5, 0, DateTimeKind.Unspecified), 53, 125, 9 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2020, 12, 17, 5, 34, 17, 0, DateTimeKind.Unspecified), 48, 9, 39 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2005, 12, 18, 12, 20, 13, 0, DateTimeKind.Unspecified), 62, 67, 90 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2016, 7, 5, 19, 1, 21, 0, DateTimeKind.Unspecified), 62, 185, 13 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2017, 10, 10, 23, 30, 6, 0, DateTimeKind.Unspecified), 43, 21, 55 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2012, 6, 1, 6, 2, 15, 0, DateTimeKind.Unspecified), 3, 61, 74 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2007, 5, 8, 6, 28, 52, 0, DateTimeKind.Unspecified), 92, 167, 24 });
        }
    }
}
