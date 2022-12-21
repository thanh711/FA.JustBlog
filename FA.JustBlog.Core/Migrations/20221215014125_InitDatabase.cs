using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Published = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostTagMaps",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTagMaps", x => new { x.TagId, x.PostId });
                    table.ForeignKey(
                        name: "FK_PostTagMaps_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTagMaps_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "Category Description 1", "Category Name 1", "Category UrlSlug 1" },
                    { 2, "Category Description 2", "Category Name 2", "Category UrlSlug 2" },
                    { 3, "Category Description 3", "Category Name 3", "Category UrlSlug 3" },
                    { 4, "Category Description 4", "Category Name 4", "Category UrlSlug 4" },
                    { 5, "Category Description 5", "Category Name 5", "Category UrlSlug 5" },
                    { 6, "Category Description 6", "Category Name 6", "Category UrlSlug 6" },
                    { 7, "Category Description 7", "Category Name 7", "Category UrlSlug 7" },
                    { 8, "Category Description 8", "Category Name 8", "Category UrlSlug 8" },
                    { 9, "Category Description 9", "Category Name 9", "Category UrlSlug 9" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Count", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, 1, "Tag Description demo:1", "Tag Name demo:1", "Tag UrlSlug demo:1" },
                    { 2, 2, "Tag Description demo:2", "Tag Name demo:2", "Tag UrlSlug demo:2" },
                    { 3, 3, "Tag Description demo:3", "Tag Name demo:3", "Tag UrlSlug demo:3" },
                    { 4, 4, "Tag Description demo:4", "Tag Name demo:4", "Tag UrlSlug demo:4" },
                    { 5, 5, "Tag Description demo:5", "Tag Name demo:5", "Tag UrlSlug demo:5" },
                    { 6, 6, "Tag Description demo:6", "Tag Name demo:6", "Tag UrlSlug demo:6" },
                    { 7, 7, "Tag Description demo:7", "Tag Name demo:7", "Tag UrlSlug demo:7" },
                    { 8, 8, "Tag Description demo:8", "Tag Name demo:8", "Tag UrlSlug demo:8" },
                    { 9, 9, "Tag Description demo:9", "Tag Name demo:9", "Tag UrlSlug demo:9" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Modified", "PostContent", "PostedOn", "ShortDescription", "Title", "UrlSlug" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:1", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post ShortDescription demo:1", "Post Title demo:1", "Post UrlSlug demo:1" },
                    { 2, 1, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:2", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post ShortDescription demo:2", "Post Title demo:2", "Post UrlSlug demo:2" },
                    { 3, 1, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:3", new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post ShortDescription demo:3", "Post Title demo:3", "Post UrlSlug demo:3" },
                    { 4, 1, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:4", new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post ShortDescription demo:4", "Post Title demo:4", "Post UrlSlug demo:4" },
                    { 5, 2, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:5", new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post ShortDescription demo:5", "Post Title demo:5", "Post UrlSlug demo:5" },
                    { 6, 2, new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:6", new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post ShortDescription demo:6", "Post Title demo:6", "Post UrlSlug demo:6" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Modified", "PostContent", "PostedOn", "Published", "ShortDescription", "Title", "UrlSlug" },
                values: new object[,]
                {
                    { 7, 3, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:7", new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Post ShortDescription demo:7", "Post Title demo:7", "Post UrlSlug demo:7" },
                    { 8, 4, new DateTime(2020, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:8", new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Post ShortDescription demo:8", "Post Title demo:8", "Post UrlSlug demo:8" },
                    { 9, 4, new DateTime(2020, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:9", new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Post ShortDescription demo:9", "Post Title demo:9", "Post UrlSlug demo:9" }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 4, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 1, 3 },
                    { 3, 3 },
                    { 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTagMaps_PostId",
                table: "PostTagMaps",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTagMaps");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
