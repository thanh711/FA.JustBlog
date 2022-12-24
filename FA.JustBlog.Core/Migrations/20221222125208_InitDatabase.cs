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
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    RateCount = table.Column<int>(type: "int", nullable: false),
                    TotalRate = table.Column<int>(type: "int", nullable: false),
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
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, "Category Description 1", "Category 1", "category-urlslug 1" },
                    { 2, "Category Description 2", "Category 2", "category-urlslug 2" },
                    { 3, "Category Description 3", "Category 3", "category-urlslug 3" },
                    { 4, "Category Description 4", "Category 4", "category-urlslug 4" },
                    { 5, "Category Description 5", "Category 5", "category-urlslug 5" },
                    { 6, "Category Description 6", "Category 6", "category-urlslug 6" },
                    { 7, "Category Description 7", "Category 7", "category-urlslug 7" },
                    { 8, "Category Description 8", "Category 8", "category-urlslug 8" },
                    { 9, "Category Description 9", "Category 9", "category-urlslug 9" },
                    { 10, "Category Description 10", "Category 10", "category-urlslug 10" },
                    { 11, "Category Description 11", "Category 11", "category-urlslug 11" },
                    { 12, "Category Description 12", "Category 12", "category-urlslug 12" },
                    { 13, "Category Description 13", "Category 13", "category-urlslug 13" },
                    { 14, "Category Description 14", "Category 14", "category-urlslug 14" },
                    { 15, "Category Description 15", "Category 15", "category-urlslug 15" },
                    { 16, "Category Description 16", "Category 16", "category-urlslug 16" },
                    { 17, "Category Description 17", "Category 17", "category-urlslug 17" },
                    { 18, "Category Description 18", "Category 18", "category-urlslug 18" },
                    { 19, "Category Description 19", "Category 19", "category-urlslug 19" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Count", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, 1, "Tag Description demo:1", "instagram", "tag-urlslug-demo1" },
                    { 2, 2, "Tag Description demo:2", "love", "tag-urlslug-demo2" },
                    { 3, 3, "Tag Description demo:3", "like", "tag-urlslug-demo3" },
                    { 4, 4, "Tag Description demo:4", "instagood", "tag-urlslug-demo4" },
                    { 5, 5, "Tag Description demo:5", "follow", "tag-urlslug-demo5" },
                    { 6, 6, "Tag Description demo:6", "likeforlikes", "tag-urlslug-demo6" },
                    { 7, 7, "Tag Description demo:7", "viral", "tag-urlslug-demo7" },
                    { 8, 8, "Tag Description demo:8", "new", "tag-urlslug-demo8" },
                    { 9, 9, "Tag Description demo:9", "photography", "tag-urlslug-demo9" },
                    { 10, 91, "Tag Description demo:10", "meme", "tag-urlslug-demo10" },
                    { 11, 92, "Tag Description demo:11", "girl", "tag-urlslug-demo11" },
                    { 12, 93, "Tag Description demo:12", "explorepage", "tag-urlslug-demo12" },
                    { 13, 94, "Tag Description demo:13", "india", "tag-urlslug-demo13" },
                    { 14, 95, "Tag Description demo:14", "new", "tag-urlslug-demo14" },
                    { 15, 96, "Tag Description demo:15", "car", "tag-urlslug-demo15" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Modified", "PostContent", "PostedOn", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "ViewCount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WASHINGTON/KYIV, Dec 22 (Reuters) - President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.\r\n\r\nZelenskiy's comments on Wednesday come as Republicans - some of whom have voiced increasing scepticism about sending so much aid to Ukraine - are set to take control of the U.S. House of Representatives from Democrats on Jan. 3.", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, "President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.", "Ukraine's Zelenskiy tells U.S. Congress aid is 'not charity', urges more support", 94, "post-urlslug-demo1", 98 },
                    { 2, 1, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "LONDON, Dec 22 (Reuters) - Trillions of dollars wiped off world stocks, bond market tantrums, whip-sawing currency and commodities and the collapse of a few crypto empires - 2022 has been perhaps the most turbulent year investors have ever seen, and for good reason.\r\n\r\nTallying the final numbers is useful but doesn't even come close to telling the whole story.\r\n\r\nYes, global equities are down $14 trillion and heading for their second worst year on record, but there have been nearly 300 interest rate hikes and a trio of 10%-plus rallies in that time making the volatility freakish.", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, "LONDON, Dec 22 (Reuters) - Trillions of dollars wiped off world stocks, bond market tantrums, whip-sawing currency and commodities and the collapse of a few crypto empires - 2022 has been perhaps the most turbulent year investors have ever seen, and for good reason", "How 2022 shocked, rocked and rolled global markets", 165, "post-urlslug-demo2", 4 },
                    { 3, 1, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:", new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, "NEW YORK/LONDON, Dec 22 (Reuters) - Bankers in New York and London are bracing for year-end bonuses that recruiters estimate are 30% to 50% lower, while some may receive none at all as dealmaking sputters and economic gloom sets takes hold.", "Banker bonuses go from boom to bust in jarring reversal", 140, "post-urlslug-demo3", 54 },
                    { 4, 1, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "A general view of hydrogen electrolysis plant called 'REFHYNE', one of the world's first green hydrogen plants, during a launch event at Shell's Rhineland refinery in Wesseling near Cologne, Germany, July 2, 2021. REUTERS/Thilo Schmuelgen.A general view of hydrogen electrolysis plant called 'REFHYNE', one of the world's first green hydrogen plants, during a launch event at Shell's Rhineland refinery in Wesseling near Cologne, Germany, July 2, 2021. REUTERS/Thilo Schmuelgen", new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, "A general view of hydrogen electrolysis plant called 'REFHYNE', one of the world's first green hydrogen plants, during a launch event at Shell's Rhineland refinery in Wesseling near Cologne, Germany, July 2, 2021. REUTERS/Thilo Schmuelgen", "Has green hydrogen sprung a leak?", 116, "post-urlslug-demo4", 1 },
                    { 5, 2, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.", new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, "President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.", "Toshiba's preferred bidder to seal $10.6 bln loan deal this week -Yomiuri", 130, "post-urlslug-demo5", 74 },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:6", new DateTime(2013, 2, 13, 12, 27, 43, 0, DateTimeKind.Unspecified), 28, "Post ShortDescription demo:6", "Post Title demo:6", 10, "post-urlslug-demo6", 66 },
                    { 7, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:7", new DateTime(2008, 10, 30, 23, 12, 30, 0, DateTimeKind.Unspecified), 97, "Post ShortDescription demo:7", "Post Title demo:7", 178, "post-urlslug-demo7", 33 },
                    { 8, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:8", new DateTime(2005, 9, 3, 21, 5, 21, 0, DateTimeKind.Unspecified), 27, "Post ShortDescription demo:8", "Post Title demo:8", 1, "post-urlslug-demo8", 10 },
                    { 9, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:9", new DateTime(2019, 4, 23, 4, 10, 4, 0, DateTimeKind.Unspecified), 51, "Post ShortDescription demo:9", "Post Title demo:9", 74, "post-urlslug-demo9", 77 },
                    { 10, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:10", new DateTime(2001, 1, 21, 16, 8, 46, 0, DateTimeKind.Unspecified), 18, "Post ShortDescription demo:10", "Post Title demo:10", 189, "post-urlslug-demo10", 34 },
                    { 11, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:11", new DateTime(2010, 10, 18, 8, 17, 31, 0, DateTimeKind.Unspecified), 13, "Post ShortDescription demo:11", "Post Title demo:11", 117, "post-urlslug-demo11", 68 },
                    { 12, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:12", new DateTime(2014, 2, 18, 16, 39, 58, 0, DateTimeKind.Unspecified), 71, "Post ShortDescription demo:12", "Post Title demo:12", 107, "post-urlslug-demo12", 76 },
                    { 13, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:13", new DateTime(2020, 9, 11, 18, 50, 39, 0, DateTimeKind.Unspecified), 56, "Post ShortDescription demo:13", "Post Title demo:13", 44, "post-urlslug-demo13", 4 },
                    { 14, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:14", new DateTime(2009, 9, 20, 14, 18, 47, 0, DateTimeKind.Unspecified), 85, "Post ShortDescription demo:14", "Post Title demo:14", 166, "post-urlslug-demo14", 52 },
                    { 15, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:15", new DateTime(2003, 4, 5, 21, 58, 0, 0, DateTimeKind.Unspecified), 69, "Post ShortDescription demo:15", "Post Title demo:15", 2, "post-urlslug-demo15", 2 },
                    { 16, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:16", new DateTime(2011, 11, 22, 8, 13, 0, 0, DateTimeKind.Unspecified), 91, "Post ShortDescription demo:16", "Post Title demo:16", 9, "post-urlslug-demo16", 44 },
                    { 17, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:17", new DateTime(2019, 7, 6, 6, 19, 49, 0, DateTimeKind.Unspecified), 83, "Post ShortDescription demo:17", "Post Title demo:17", 55, "post-urlslug-demo17", 26 },
                    { 18, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:18", new DateTime(2005, 8, 12, 3, 49, 57, 0, DateTimeKind.Unspecified), 22, "Post ShortDescription demo:18", "Post Title demo:18", 164, "post-urlslug-demo18", 6 },
                    { 19, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:19", new DateTime(2022, 1, 10, 2, 16, 57, 0, DateTimeKind.Unspecified), 78, "Post ShortDescription demo:19", "Post Title demo:19", 137, "post-urlslug-demo19", 14 },
                    { 20, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:20", new DateTime(2009, 8, 13, 18, 29, 31, 0, DateTimeKind.Unspecified), 5, "Post ShortDescription demo:20", "Post Title demo:20", 157, "post-urlslug-demo20", 86 },
                    { 21, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:21", new DateTime(2020, 4, 13, 16, 44, 57, 0, DateTimeKind.Unspecified), 16, "Post ShortDescription demo:21", "Post Title demo:21", 194, "post-urlslug-demo21", 68 },
                    { 22, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:22", new DateTime(2019, 2, 17, 9, 42, 12, 0, DateTimeKind.Unspecified), 13, "Post ShortDescription demo:22", "Post Title demo:22", 42, "post-urlslug-demo22", 89 },
                    { 23, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:23", new DateTime(2009, 1, 4, 14, 47, 8, 0, DateTimeKind.Unspecified), 46, "Post ShortDescription demo:23", "Post Title demo:23", 21, "post-urlslug-demo23", 26 },
                    { 24, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:24", new DateTime(2012, 9, 13, 18, 31, 58, 0, DateTimeKind.Unspecified), 36, "Post ShortDescription demo:24", "Post Title demo:24", 6, "post-urlslug-demo24", 61 },
                    { 25, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:25", new DateTime(2013, 3, 19, 20, 28, 40, 0, DateTimeKind.Unspecified), 36, "Post ShortDescription demo:25", "Post Title demo:25", 160, "post-urlslug-demo25", 29 },
                    { 26, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:26", new DateTime(2017, 5, 23, 0, 36, 32, 0, DateTimeKind.Unspecified), 46, "Post ShortDescription demo:26", "Post Title demo:26", 136, "post-urlslug-demo26", 65 },
                    { 27, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:27", new DateTime(2015, 6, 28, 18, 53, 52, 0, DateTimeKind.Unspecified), 72, "Post ShortDescription demo:27", "Post Title demo:27", 103, "post-urlslug-demo27", 93 },
                    { 28, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:28", new DateTime(2005, 9, 28, 11, 44, 59, 0, DateTimeKind.Unspecified), 12, "Post ShortDescription demo:28", "Post Title demo:28", 104, "post-urlslug-demo28", 39 },
                    { 29, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:29", new DateTime(2004, 9, 3, 21, 44, 18, 0, DateTimeKind.Unspecified), 88, "Post ShortDescription demo:29", "Post Title demo:29", 185, "post-urlslug-demo29", 45 },
                    { 30, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:30", new DateTime(2015, 5, 9, 16, 1, 51, 0, DateTimeKind.Unspecified), 16, "Post ShortDescription demo:30", "Post Title demo:30", 130, "post-urlslug-demo30", 60 },
                    { 31, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:31", new DateTime(2005, 6, 2, 21, 2, 49, 0, DateTimeKind.Unspecified), 6, "Post ShortDescription demo:31", "Post Title demo:31", 87, "post-urlslug-demo31", 15 },
                    { 32, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:32", new DateTime(2005, 2, 3, 1, 6, 33, 0, DateTimeKind.Unspecified), 52, "Post ShortDescription demo:32", "Post Title demo:32", 154, "post-urlslug-demo32", 15 },
                    { 33, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:33", new DateTime(2017, 10, 17, 1, 16, 34, 0, DateTimeKind.Unspecified), 62, "Post ShortDescription demo:33", "Post Title demo:33", 17, "post-urlslug-demo33", 63 },
                    { 34, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:34", new DateTime(2018, 11, 20, 20, 35, 27, 0, DateTimeKind.Unspecified), 48, "Post ShortDescription demo:34", "Post Title demo:34", 185, "post-urlslug-demo34", 5 },
                    { 35, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:35", new DateTime(2021, 5, 20, 13, 32, 33, 0, DateTimeKind.Unspecified), 62, "Post ShortDescription demo:35", "Post Title demo:35", 196, "post-urlslug-demo35", 42 },
                    { 36, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:36", new DateTime(2011, 8, 16, 19, 16, 41, 0, DateTimeKind.Unspecified), 37, "Post ShortDescription demo:36", "Post Title demo:36", 55, "post-urlslug-demo36", 44 },
                    { 37, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:37", new DateTime(2020, 3, 17, 18, 27, 47, 0, DateTimeKind.Unspecified), 2, "Post ShortDescription demo:37", "Post Title demo:37", 114, "post-urlslug-demo37", 5 },
                    { 38, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:38", new DateTime(2007, 7, 14, 3, 0, 55, 0, DateTimeKind.Unspecified), 32, "Post ShortDescription demo:38", "Post Title demo:38", 14, "post-urlslug-demo38", 50 },
                    { 39, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:39", new DateTime(2007, 3, 12, 0, 53, 34, 0, DateTimeKind.Unspecified), 69, "Post ShortDescription demo:39", "Post Title demo:39", 16, "post-urlslug-demo39", 76 },
                    { 40, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:40", new DateTime(2008, 1, 2, 9, 21, 31, 0, DateTimeKind.Unspecified), 83, "Post ShortDescription demo:40", "Post Title demo:40", 196, "post-urlslug-demo40", 63 },
                    { 41, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:41", new DateTime(2015, 2, 25, 22, 33, 11, 0, DateTimeKind.Unspecified), 75, "Post ShortDescription demo:41", "Post Title demo:41", 50, "post-urlslug-demo41", 16 },
                    { 42, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:42", new DateTime(2010, 9, 15, 19, 52, 39, 0, DateTimeKind.Unspecified), 47, "Post ShortDescription demo:42", "Post Title demo:42", 129, "post-urlslug-demo42", 9 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Modified", "PostContent", "PostedOn", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "ViewCount" },
                values: new object[,]
                {
                    { 43, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:43", new DateTime(2010, 8, 16, 15, 17, 40, 0, DateTimeKind.Unspecified), 38, "Post ShortDescription demo:43", "Post Title demo:43", 155, "post-urlslug-demo43", 95 },
                    { 44, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:44", new DateTime(2009, 8, 15, 14, 29, 11, 0, DateTimeKind.Unspecified), 16, "Post ShortDescription demo:44", "Post Title demo:44", 79, "post-urlslug-demo44", 29 },
                    { 45, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:45", new DateTime(2001, 9, 24, 16, 23, 58, 0, DateTimeKind.Unspecified), 46, "Post ShortDescription demo:45", "Post Title demo:45", 181, "post-urlslug-demo45", 96 },
                    { 46, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:46", new DateTime(2005, 9, 9, 18, 36, 6, 0, DateTimeKind.Unspecified), 69, "Post ShortDescription demo:46", "Post Title demo:46", 78, "post-urlslug-demo46", 84 },
                    { 47, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:47", new DateTime(2003, 11, 24, 12, 54, 50, 0, DateTimeKind.Unspecified), 82, "Post ShortDescription demo:47", "Post Title demo:47", 46, "post-urlslug-demo47", 9 },
                    { 48, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:48", new DateTime(2015, 9, 6, 13, 30, 24, 0, DateTimeKind.Unspecified), 60, "Post ShortDescription demo:48", "Post Title demo:48", 49, "post-urlslug-demo48", 31 },
                    { 49, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:49", new DateTime(2015, 3, 26, 1, 11, 33, 0, DateTimeKind.Unspecified), 98, "Post ShortDescription demo:49", "Post Title demo:49", 76, "post-urlslug-demo49", 70 }
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
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

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
                name: "Comments");

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
