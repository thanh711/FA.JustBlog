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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, 3, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WASHINGTON/KYIV, Dec 22 (Reuters) - President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.\r\n\r\nZelenskiy's comments on Wednesday come as Republicans - some of whom have voiced increasing scepticism about sending so much aid to Ukraine - are set to take control of the U.S. House of Representatives from Democrats on Jan. 3.", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, "President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.", "Ukraine's Zelenskiy tells U.S. Congress aid is 'not charity', urges more support", 118, "post-urlslug-demo1", 67 },
                    { 2, 6, new DateTime(2020, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "LONDON, Dec 22 (Reuters) - Trillions of dollars wiped off world stocks, bond market tantrums, whip-sawing currency and commodities and the collapse of a few crypto empires - 2022 has been perhaps the most turbulent year investors have ever seen, and for good reason.\r\n\r\nTallying the final numbers is useful but doesn't even come close to telling the whole story.\r\n\r\nYes, global equities are down $14 trillion and heading for their second worst year on record, but there have been nearly 300 interest rate hikes and a trio of 10%-plus rallies in that time making the volatility freakish.", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, "LONDON, Dec 22 (Reuters) - Trillions of dollars wiped off world stocks, bond market tantrums, whip-sawing currency and commodities and the collapse of a few crypto empires - 2022 has been perhaps the most turbulent year investors have ever seen, and for good reason", "How 2022 shocked, rocked and rolled global markets", 104, "post-urlslug-demo2", 73 },
                    { 3, 9, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:", new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, "NEW YORK/LONDON, Dec 22 (Reuters) - Bankers in New York and London are bracing for year-end bonuses that recruiters estimate are 30% to 50% lower, while some may receive none at all as dealmaking sputters and economic gloom sets takes hold.", "Banker bonuses go from boom to bust in jarring reversal", 118, "post-urlslug-demo3", 58 },
                    { 4, 4, new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "A general view of hydrogen electrolysis plant called 'REFHYNE', one of the world's first green hydrogen plants, during a launch event at Shell's Rhineland refinery in Wesseling near Cologne, Germany, July 2, 2021. REUTERS/Thilo Schmuelgen.A general view of hydrogen electrolysis plant called 'REFHYNE', one of the world's first green hydrogen plants, during a launch event at Shell's Rhineland refinery in Wesseling near Cologne, Germany, July 2, 2021. REUTERS/Thilo Schmuelgen", new DateTime(2020, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "A general view of hydrogen electrolysis plant called 'REFHYNE', one of the world's first green hydrogen plants, during a launch event at Shell's Rhineland refinery in Wesseling near Cologne, Germany, July 2, 2021. REUTERS/Thilo Schmuelgen", "Has green hydrogen sprung a leak?", 127, "post-urlslug-demo4", 40 },
                    { 5, 1, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.", new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.", "Toshiba's preferred bidder to seal $10.6 bln loan deal this week -Yomiuri", 9, "post-urlslug-demo5", 45 },
                    { 6, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:6", new DateTime(2003, 8, 8, 2, 29, 36, 0, DateTimeKind.Unspecified), 5, "Post ShortDescription demo:6", "Post Title demo:6", 173, "post-urlslug-demo6", 2 },
                    { 7, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:7", new DateTime(2019, 11, 10, 18, 45, 54, 0, DateTimeKind.Unspecified), 84, "Post ShortDescription demo:7", "Post Title demo:7", 175, "post-urlslug-demo7", 21 },
                    { 8, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:8", new DateTime(2012, 7, 21, 9, 22, 46, 0, DateTimeKind.Unspecified), 51, "Post ShortDescription demo:8", "Post Title demo:8", 172, "post-urlslug-demo8", 49 },
                    { 9, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:9", new DateTime(2009, 7, 30, 3, 38, 12, 0, DateTimeKind.Unspecified), 39, "Post ShortDescription demo:9", "Post Title demo:9", 117, "post-urlslug-demo9", 98 },
                    { 10, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:10", new DateTime(2002, 3, 16, 12, 37, 4, 0, DateTimeKind.Unspecified), 2, "Post ShortDescription demo:10", "Post Title demo:10", 136, "post-urlslug-demo10", 69 },
                    { 11, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:11", new DateTime(2007, 1, 25, 22, 28, 33, 0, DateTimeKind.Unspecified), 92, "Post ShortDescription demo:11", "Post Title demo:11", 124, "post-urlslug-demo11", 18 },
                    { 12, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:12", new DateTime(2008, 8, 5, 21, 8, 40, 0, DateTimeKind.Unspecified), 15, "Post ShortDescription demo:12", "Post Title demo:12", 119, "post-urlslug-demo12", 94 },
                    { 13, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:13", new DateTime(2016, 10, 24, 20, 45, 2, 0, DateTimeKind.Unspecified), 18, "Post ShortDescription demo:13", "Post Title demo:13", 9, "post-urlslug-demo13", 29 },
                    { 14, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:14", new DateTime(2002, 10, 16, 6, 51, 27, 0, DateTimeKind.Unspecified), 6, "Post ShortDescription demo:14", "Post Title demo:14", 25, "post-urlslug-demo14", 29 },
                    { 15, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:15", new DateTime(2005, 8, 26, 22, 0, 47, 0, DateTimeKind.Unspecified), 24, "Post ShortDescription demo:15", "Post Title demo:15", 196, "post-urlslug-demo15", 38 },
                    { 16, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:16", new DateTime(2002, 11, 13, 1, 12, 16, 0, DateTimeKind.Unspecified), 96, "Post ShortDescription demo:16", "Post Title demo:16", 126, "post-urlslug-demo16", 39 },
                    { 17, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:17", new DateTime(2007, 4, 2, 15, 19, 55, 0, DateTimeKind.Unspecified), 75, "Post ShortDescription demo:17", "Post Title demo:17", 158, "post-urlslug-demo17", 61 },
                    { 18, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:18", new DateTime(2019, 2, 20, 5, 47, 17, 0, DateTimeKind.Unspecified), 54, "Post ShortDescription demo:18", "Post Title demo:18", 45, "post-urlslug-demo18", 89 },
                    { 19, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:19", new DateTime(2010, 7, 7, 6, 42, 19, 0, DateTimeKind.Unspecified), 84, "Post ShortDescription demo:19", "Post Title demo:19", 58, "post-urlslug-demo19", 8 },
                    { 20, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:20", new DateTime(2005, 4, 23, 23, 18, 25, 0, DateTimeKind.Unspecified), 92, "Post ShortDescription demo:20", "Post Title demo:20", 160, "post-urlslug-demo20", 23 },
                    { 21, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:21", new DateTime(2020, 1, 7, 16, 50, 2, 0, DateTimeKind.Unspecified), 54, "Post ShortDescription demo:21", "Post Title demo:21", 24, "post-urlslug-demo21", 57 },
                    { 22, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:22", new DateTime(2004, 12, 23, 19, 7, 53, 0, DateTimeKind.Unspecified), 32, "Post ShortDescription demo:22", "Post Title demo:22", 24, "post-urlslug-demo22", 22 },
                    { 23, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:23", new DateTime(2015, 1, 12, 2, 32, 14, 0, DateTimeKind.Unspecified), 55, "Post ShortDescription demo:23", "Post Title demo:23", 128, "post-urlslug-demo23", 20 },
                    { 24, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:24", new DateTime(2006, 4, 1, 9, 49, 34, 0, DateTimeKind.Unspecified), 64, "Post ShortDescription demo:24", "Post Title demo:24", 39, "post-urlslug-demo24", 63 },
                    { 25, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:25", new DateTime(2017, 6, 6, 2, 13, 18, 0, DateTimeKind.Unspecified), 89, "Post ShortDescription demo:25", "Post Title demo:25", 86, "post-urlslug-demo25", 83 },
                    { 26, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:26", new DateTime(2010, 12, 6, 6, 59, 22, 0, DateTimeKind.Unspecified), 25, "Post ShortDescription demo:26", "Post Title demo:26", 170, "post-urlslug-demo26", 99 },
                    { 27, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:27", new DateTime(2018, 2, 16, 3, 31, 42, 0, DateTimeKind.Unspecified), 64, "Post ShortDescription demo:27", "Post Title demo:27", 85, "post-urlslug-demo27", 97 },
                    { 28, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:28", new DateTime(2000, 2, 12, 8, 46, 18, 0, DateTimeKind.Unspecified), 90, "Post ShortDescription demo:28", "Post Title demo:28", 109, "post-urlslug-demo28", 83 },
                    { 29, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:29", new DateTime(2014, 7, 12, 12, 42, 26, 0, DateTimeKind.Unspecified), 93, "Post ShortDescription demo:29", "Post Title demo:29", 126, "post-urlslug-demo29", 25 },
                    { 30, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:30", new DateTime(2000, 12, 11, 6, 45, 35, 0, DateTimeKind.Unspecified), 54, "Post ShortDescription demo:30", "Post Title demo:30", 119, "post-urlslug-demo30", 54 },
                    { 31, 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:31", new DateTime(2020, 6, 13, 12, 6, 17, 0, DateTimeKind.Unspecified), 9, "Post ShortDescription demo:31", "Post Title demo:31", 31, "post-urlslug-demo31", 43 },
                    { 32, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:32", new DateTime(2004, 7, 24, 8, 35, 27, 0, DateTimeKind.Unspecified), 92, "Post ShortDescription demo:32", "Post Title demo:32", 151, "post-urlslug-demo32", 31 },
                    { 33, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:33", new DateTime(2011, 2, 23, 22, 25, 48, 0, DateTimeKind.Unspecified), 28, "Post ShortDescription demo:33", "Post Title demo:33", 187, "post-urlslug-demo33", 52 },
                    { 34, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:34", new DateTime(2009, 2, 8, 21, 54, 56, 0, DateTimeKind.Unspecified), 20, "Post ShortDescription demo:34", "Post Title demo:34", 127, "post-urlslug-demo34", 51 },
                    { 35, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:35", new DateTime(2020, 4, 5, 9, 57, 31, 0, DateTimeKind.Unspecified), 19, "Post ShortDescription demo:35", "Post Title demo:35", 181, "post-urlslug-demo35", 36 },
                    { 36, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:36", new DateTime(2022, 6, 21, 22, 36, 15, 0, DateTimeKind.Unspecified), 24, "Post ShortDescription demo:36", "Post Title demo:36", 36, "post-urlslug-demo36", 59 },
                    { 37, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:37", new DateTime(2010, 2, 12, 22, 43, 6, 0, DateTimeKind.Unspecified), 57, "Post ShortDescription demo:37", "Post Title demo:37", 195, "post-urlslug-demo37", 85 },
                    { 38, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:38", new DateTime(2011, 6, 16, 7, 52, 6, 0, DateTimeKind.Unspecified), 50, "Post ShortDescription demo:38", "Post Title demo:38", 160, "post-urlslug-demo38", 56 },
                    { 39, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:39", new DateTime(2021, 11, 7, 2, 15, 19, 0, DateTimeKind.Unspecified), 13, "Post ShortDescription demo:39", "Post Title demo:39", 50, "post-urlslug-demo39", 71 },
                    { 40, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:40", new DateTime(2004, 4, 15, 10, 13, 8, 0, DateTimeKind.Unspecified), 94, "Post ShortDescription demo:40", "Post Title demo:40", 88, "post-urlslug-demo40", 57 },
                    { 41, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:41", new DateTime(2019, 11, 2, 3, 35, 44, 0, DateTimeKind.Unspecified), 64, "Post ShortDescription demo:41", "Post Title demo:41", 93, "post-urlslug-demo41", 97 },
                    { 42, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:42", new DateTime(2021, 6, 25, 14, 16, 38, 0, DateTimeKind.Unspecified), 56, "Post ShortDescription demo:42", "Post Title demo:42", 27, "post-urlslug-demo42", 60 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Modified", "PostContent", "PostedOn", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "ViewCount" },
                values: new object[,]
                {
                    { 43, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:43", new DateTime(2015, 10, 13, 5, 25, 43, 0, DateTimeKind.Unspecified), 75, "Post ShortDescription demo:43", "Post Title demo:43", 136, "post-urlslug-demo43", 73 },
                    { 44, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:44", new DateTime(2009, 6, 7, 13, 39, 16, 0, DateTimeKind.Unspecified), 82, "Post ShortDescription demo:44", "Post Title demo:44", 68, "post-urlslug-demo44", 28 },
                    { 45, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:45", new DateTime(2016, 5, 25, 14, 8, 55, 0, DateTimeKind.Unspecified), 27, "Post ShortDescription demo:45", "Post Title demo:45", 160, "post-urlslug-demo45", 21 },
                    { 46, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:46", new DateTime(2016, 12, 1, 3, 14, 50, 0, DateTimeKind.Unspecified), 66, "Post ShortDescription demo:46", "Post Title demo:46", 46, "post-urlslug-demo46", 69 },
                    { 47, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:47", new DateTime(2003, 12, 30, 1, 9, 17, 0, DateTimeKind.Unspecified), 77, "Post ShortDescription demo:47", "Post Title demo:47", 144, "post-urlslug-demo47", 34 },
                    { 48, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:48", new DateTime(2019, 4, 19, 8, 10, 5, 0, DateTimeKind.Unspecified), 53, "Post ShortDescription demo:48", "Post Title demo:48", 125, "post-urlslug-demo48", 9 },
                    { 49, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:49", new DateTime(2020, 12, 17, 5, 34, 17, 0, DateTimeKind.Unspecified), 48, "Post ShortDescription demo:49", "Post Title demo:49", 9, "post-urlslug-demo49", 39 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Modified", "PostContent", "PostedOn", "Published", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "ViewCount" },
                values: new object[,]
                {
                    { 50, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:50", new DateTime(2005, 12, 18, 12, 20, 13, 0, DateTimeKind.Unspecified), 1, 62, "Post ShortDescription demo:50", "Post Title demo:50", 67, "post-urlslug-demo50", 90 },
                    { 51, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:51", new DateTime(2016, 7, 5, 19, 1, 21, 0, DateTimeKind.Unspecified), 1, 62, "Post ShortDescription demo:51", "Post Title demo:51", 185, "post-urlslug-demo51", 13 },
                    { 52, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:52", new DateTime(2017, 10, 10, 23, 30, 6, 0, DateTimeKind.Unspecified), 1, 43, "Post ShortDescription demo:52", "Post Title demo:52", 21, "post-urlslug-demo52", 55 },
                    { 53, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:53", new DateTime(2012, 6, 1, 6, 2, 15, 0, DateTimeKind.Unspecified), 1, 3, "Post ShortDescription demo:53", "Post Title demo:53", 61, "post-urlslug-demo53", 74 },
                    { 54, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post PostContent demo:54", new DateTime(2007, 5, 8, 6, 28, 52, 0, DateTimeKind.Unspecified), 1, 92, "Post ShortDescription demo:54", "Post Title demo:54", 167, "post-urlslug-demo54", 24 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentHeader", "CommentText", "CommentTime", "Email", "Name", "PostId" },
                values: new object[,]
                {
                    { 1, "CommentHeader 1", "CommentText 1", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8193), "commentemail 1@gmail.com", "comment name 1", 17 },
                    { 2, "CommentHeader 2", "CommentText 2", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8198), "commentemail 2@gmail.com", "comment name 2", 12 },
                    { 3, "CommentHeader 3", "CommentText 3", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8200), "commentemail 3@gmail.com", "comment name 3", 5 },
                    { 4, "CommentHeader 4", "CommentText 4", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8202), "commentemail 4@gmail.com", "comment name 4", 35 },
                    { 5, "CommentHeader 5", "CommentText 5", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8203), "commentemail 5@gmail.com", "comment name 5", 22 },
                    { 6, "CommentHeader 6", "CommentText 6", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8247), "commentemail 6@gmail.com", "comment name 6", 47 },
                    { 7, "CommentHeader 7", "CommentText 7", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8249), "commentemail 7@gmail.com", "comment name 7", 2 },
                    { 8, "CommentHeader 8", "CommentText 8", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8250), "commentemail 8@gmail.com", "comment name 8", 33 },
                    { 9, "CommentHeader 9", "CommentText 9", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8252), "commentemail 9@gmail.com", "comment name 9", 17 },
                    { 10, "CommentHeader 10", "CommentText 10", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8256), "commentemail 10@gmail.com", "comment name 10", 12 },
                    { 11, "CommentHeader 11", "CommentText 11", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8258), "commentemail 11@gmail.com", "comment name 11", 3 },
                    { 12, "CommentHeader 12", "CommentText 12", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8259), "commentemail 12@gmail.com", "comment name 12", 2 },
                    { 13, "CommentHeader 13", "CommentText 13", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8261), "commentemail 13@gmail.com", "comment name 13", 34 },
                    { 14, "CommentHeader 14", "CommentText 14", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8263), "commentemail 14@gmail.com", "comment name 14", 38 },
                    { 15, "CommentHeader 15", "CommentText 15", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8264), "commentemail 15@gmail.com", "comment name 15", 44 },
                    { 16, "CommentHeader 16", "CommentText 16", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8266), "commentemail 16@gmail.com", "comment name 16", 16 },
                    { 17, "CommentHeader 17", "CommentText 17", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8268), "commentemail 17@gmail.com", "comment name 17", 9 },
                    { 18, "CommentHeader 18", "CommentText 18", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8271), "commentemail 18@gmail.com", "comment name 18", 2 },
                    { 19, "CommentHeader 19", "CommentText 19", new DateTime(2022, 12, 26, 9, 7, 4, 333, DateTimeKind.Local).AddTicks(8273), "commentemail 19@gmail.com", "comment name 19", 15 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 9, 1 },
                    { 15, 1 },
                    { 22, 1 },
                    { 25, 1 },
                    { 30, 1 },
                    { 36, 1 },
                    { 1, 2 },
                    { 4, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 11, 2 },
                    { 12, 2 },
                    { 25, 2 },
                    { 28, 2 },
                    { 32, 2 },
                    { 34, 2 },
                    { 36, 2 },
                    { 45, 2 },
                    { 48, 2 },
                    { 49, 2 },
                    { 1, 3 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 7, 3 },
                    { 9, 3 },
                    { 15, 3 },
                    { 17, 3 },
                    { 23, 3 },
                    { 29, 3 },
                    { 36, 3 },
                    { 38, 3 },
                    { 44, 3 },
                    { 48, 3 },
                    { 49, 3 },
                    { 4, 4 },
                    { 12, 4 },
                    { 19, 4 },
                    { 20, 4 },
                    { 21, 4 },
                    { 22, 4 },
                    { 27, 4 },
                    { 36, 4 },
                    { 38, 4 },
                    { 41, 4 },
                    { 48, 4 },
                    { 6, 5 },
                    { 8, 5 },
                    { 10, 5 },
                    { 22, 5 },
                    { 26, 5 },
                    { 27, 5 },
                    { 29, 5 },
                    { 34, 5 },
                    { 35, 5 },
                    { 3, 6 },
                    { 24, 6 },
                    { 28, 6 },
                    { 30, 6 },
                    { 34, 6 },
                    { 36, 6 },
                    { 41, 6 },
                    { 2, 7 },
                    { 8, 7 },
                    { 11, 7 },
                    { 14, 7 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 21, 7 },
                    { 25, 7 },
                    { 27, 7 },
                    { 45, 7 },
                    { 48, 7 },
                    { 1, 8 },
                    { 4, 8 },
                    { 6, 8 },
                    { 12, 8 },
                    { 15, 8 },
                    { 20, 8 },
                    { 29, 8 },
                    { 33, 8 },
                    { 40, 8 },
                    { 46, 8 },
                    { 49, 8 },
                    { 6, 9 },
                    { 10, 9 },
                    { 12, 9 },
                    { 16, 9 },
                    { 17, 9 },
                    { 20, 9 },
                    { 22, 9 },
                    { 28, 9 },
                    { 35, 9 },
                    { 40, 9 },
                    { 41, 9 },
                    { 43, 9 },
                    { 44, 9 },
                    { 46, 9 },
                    { 47, 9 },
                    { 2, 10 },
                    { 4, 10 },
                    { 7, 10 },
                    { 12, 10 },
                    { 14, 10 },
                    { 18, 10 },
                    { 25, 10 },
                    { 28, 10 },
                    { 33, 10 },
                    { 39, 10 },
                    { 41, 10 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 2, 11 },
                    { 4, 11 },
                    { 7, 11 },
                    { 12, 11 },
                    { 14, 11 },
                    { 15, 11 },
                    { 21, 11 },
                    { 36, 11 },
                    { 41, 11 },
                    { 46, 11 },
                    { 48, 11 },
                    { 2, 12 },
                    { 6, 12 },
                    { 9, 12 },
                    { 12, 12 },
                    { 18, 12 },
                    { 24, 12 },
                    { 28, 12 },
                    { 29, 12 },
                    { 35, 12 },
                    { 39, 12 },
                    { 44, 12 },
                    { 45, 12 },
                    { 3, 13 },
                    { 12, 13 },
                    { 14, 13 },
                    { 16, 13 },
                    { 25, 13 },
                    { 27, 13 },
                    { 32, 13 },
                    { 36, 13 },
                    { 38, 13 },
                    { 2, 14 },
                    { 4, 14 },
                    { 8, 14 },
                    { 12, 14 },
                    { 15, 14 },
                    { 16, 14 },
                    { 30, 14 },
                    { 36, 14 },
                    { 43, 14 },
                    { 44, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostTagMaps");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
