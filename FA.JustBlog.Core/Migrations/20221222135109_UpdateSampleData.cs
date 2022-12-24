using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class UpdateSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, 58, 99, 22 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, 65, 21, 15 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, 75, 38, 91 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, 32, 85, 75 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, 25, 152, 33 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2018, 3, 27, 7, 58, 23, 0, DateTimeKind.Unspecified), 13, 83, 16 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2019, 4, 30, 14, 46, 5, 0, DateTimeKind.Unspecified), 35, 138, 38 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2017, 10, 11, 12, 39, 16, 0, DateTimeKind.Unspecified), 39, 95, 87 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2021, 5, 24, 0, 20, 39, 0, DateTimeKind.Unspecified), 89, 72, 35 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2007, 3, 5, 8, 12, 20, 0, DateTimeKind.Unspecified), 6, 77, 19 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2020, 7, 8, 0, 15, 3, 0, DateTimeKind.Unspecified), 69, 196, 9 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2022, 4, 14, 13, 49, 24, 0, DateTimeKind.Unspecified), 24, 117, 72 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2011, 2, 9, 7, 1, 32, 0, DateTimeKind.Unspecified), 92, 145, 89 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2003, 8, 23, 7, 58, 40, 0, DateTimeKind.Unspecified), 42, 121, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2007, 6, 12, 9, 4, 24, 0, DateTimeKind.Unspecified), 15, 158, 69 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2003, 5, 11, 18, 56, 33, 0, DateTimeKind.Unspecified), 36, 63, 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2004, 1, 31, 23, 36, 41, 0, DateTimeKind.Unspecified), 81, 43, 54 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2013, 3, 21, 1, 42, 16, 0, DateTimeKind.Unspecified), 71, 37, 98 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2015, 11, 27, 5, 2, 18, 0, DateTimeKind.Unspecified), 94, 128, 88 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2004, 11, 16, 10, 37, 5, 0, DateTimeKind.Unspecified), 97, 36, 46 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2016, 7, 6, 4, 6, 43, 0, DateTimeKind.Unspecified), 95, 134, 12 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2001, 3, 12, 5, 10, 57, 0, DateTimeKind.Unspecified), 9, 81, 62 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PostedOn", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2005, 6, 5, 5, 33, 21, 0, DateTimeKind.Unspecified), 165, 28 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2017, 5, 8, 13, 41, 40, 0, DateTimeKind.Unspecified), 2, 173, 57 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2002, 3, 1, 1, 54, 32, 0, DateTimeKind.Unspecified), 76, 70, 63 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2001, 6, 6, 1, 20, 33, 0, DateTimeKind.Unspecified), 76, 17, 21 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2002, 7, 20, 15, 47, 3, 0, DateTimeKind.Unspecified), 78, 186, 76 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2018, 9, 30, 6, 51, 54, 0, DateTimeKind.Unspecified), 35, 140, 61 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2003, 9, 4, 12, 1, 0, 0, DateTimeKind.Unspecified), 47, 86, 36 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2009, 6, 3, 13, 3, 23, 0, DateTimeKind.Unspecified), 45, 40, 81 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2008, 11, 27, 6, 51, 23, 0, DateTimeKind.Unspecified), 61, 57, 10 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2016, 6, 12, 17, 1, 1, 0, DateTimeKind.Unspecified), 95, 172, 24 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2000, 3, 3, 4, 8, 20, 0, DateTimeKind.Unspecified), 37, 131, 98 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2017, 12, 8, 23, 19, 20, 0, DateTimeKind.Unspecified), 32, 175, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2005, 7, 24, 21, 57, 58, 0, DateTimeKind.Unspecified), 99, 94, 30 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2017, 3, 26, 12, 38, 39, 0, DateTimeKind.Unspecified), 2, 113, 31 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2000, 9, 23, 18, 29, 9, 0, DateTimeKind.Unspecified), 5, 140, 10 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2008, 8, 20, 1, 18, 8, 0, DateTimeKind.Unspecified), 64, 44, 74 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2016, 1, 26, 9, 10, 44, 0, DateTimeKind.Unspecified), 10, 93, 39 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2021, 10, 6, 9, 36, 50, 0, DateTimeKind.Unspecified), 36, 69, 87 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2015, 2, 14, 17, 58, 46, 0, DateTimeKind.Unspecified), 12, 76, 18 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2011, 1, 3, 22, 38, 32, 0, DateTimeKind.Unspecified), 9, 76, 33 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2015, 10, 16, 5, 2, 48, 0, DateTimeKind.Unspecified), 60, 97, 88 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2004, 2, 11, 14, 13, 10, 0, DateTimeKind.Unspecified), 1, 50, 33 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2011, 10, 17, 3, 21, 24, 0, DateTimeKind.Unspecified), 71, 36, 13 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2022, 12, 4, 18, 11, 23, 0, DateTimeKind.Unspecified), 74, 101, 26 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2000, 10, 22, 5, 32, 46, 0, DateTimeKind.Unspecified), 30, 98, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2013, 6, 3, 22, 17, 36, 0, DateTimeKind.Unspecified), 67, 177, 15 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2011, 6, 15, 8, 34, 26, 0, DateTimeKind.Unspecified), 46, 1, 34 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, 56, 94, 98 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, 76, 165, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, 46, 140, 54 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, 34, 116, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, 55, 130, 74 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2013, 2, 13, 12, 27, 43, 0, DateTimeKind.Unspecified), 28, 10, 66 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2008, 10, 30, 23, 12, 30, 0, DateTimeKind.Unspecified), 97, 178, 33 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2005, 9, 3, 21, 5, 21, 0, DateTimeKind.Unspecified), 27, 1, 10 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2019, 4, 23, 4, 10, 4, 0, DateTimeKind.Unspecified), 51, 74, 77 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2001, 1, 21, 16, 8, 46, 0, DateTimeKind.Unspecified), 18, 189, 34 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2010, 10, 18, 8, 17, 31, 0, DateTimeKind.Unspecified), 13, 117, 68 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2014, 2, 18, 16, 39, 58, 0, DateTimeKind.Unspecified), 71, 107, 76 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2020, 9, 11, 18, 50, 39, 0, DateTimeKind.Unspecified), 56, 44, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2009, 9, 20, 14, 18, 47, 0, DateTimeKind.Unspecified), 85, 166, 52 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2003, 4, 5, 21, 58, 0, 0, DateTimeKind.Unspecified), 69, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2011, 11, 22, 8, 13, 0, 0, DateTimeKind.Unspecified), 91, 9, 44 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2019, 7, 6, 6, 19, 49, 0, DateTimeKind.Unspecified), 83, 55, 26 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2005, 8, 12, 3, 49, 57, 0, DateTimeKind.Unspecified), 22, 164, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2022, 1, 10, 2, 16, 57, 0, DateTimeKind.Unspecified), 78, 137, 14 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2009, 8, 13, 18, 29, 31, 0, DateTimeKind.Unspecified), 5, 157, 86 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2020, 4, 13, 16, 44, 57, 0, DateTimeKind.Unspecified), 16, 194, 68 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2019, 2, 17, 9, 42, 12, 0, DateTimeKind.Unspecified), 13, 42, 89 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PostedOn", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2009, 1, 4, 14, 47, 8, 0, DateTimeKind.Unspecified), 21, 26 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2012, 9, 13, 18, 31, 58, 0, DateTimeKind.Unspecified), 36, 6, 61 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2013, 3, 19, 20, 28, 40, 0, DateTimeKind.Unspecified), 36, 160, 29 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2017, 5, 23, 0, 36, 32, 0, DateTimeKind.Unspecified), 46, 136, 65 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2015, 6, 28, 18, 53, 52, 0, DateTimeKind.Unspecified), 72, 103, 93 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2005, 9, 28, 11, 44, 59, 0, DateTimeKind.Unspecified), 12, 104, 39 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2004, 9, 3, 21, 44, 18, 0, DateTimeKind.Unspecified), 88, 185, 45 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2015, 5, 9, 16, 1, 51, 0, DateTimeKind.Unspecified), 16, 130, 60 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2005, 6, 2, 21, 2, 49, 0, DateTimeKind.Unspecified), 6, 87, 15 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2005, 2, 3, 1, 6, 33, 0, DateTimeKind.Unspecified), 52, 154, 15 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2017, 10, 17, 1, 16, 34, 0, DateTimeKind.Unspecified), 62, 17, 63 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2018, 11, 20, 20, 35, 27, 0, DateTimeKind.Unspecified), 48, 185, 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2021, 5, 20, 13, 32, 33, 0, DateTimeKind.Unspecified), 62, 196, 42 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2011, 8, 16, 19, 16, 41, 0, DateTimeKind.Unspecified), 37, 55, 44 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2020, 3, 17, 18, 27, 47, 0, DateTimeKind.Unspecified), 2, 114, 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2007, 7, 14, 3, 0, 55, 0, DateTimeKind.Unspecified), 32, 14, 50 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2007, 3, 12, 0, 53, 34, 0, DateTimeKind.Unspecified), 69, 16, 76 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2008, 1, 2, 9, 21, 31, 0, DateTimeKind.Unspecified), 83, 196, 63 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2015, 2, 25, 22, 33, 11, 0, DateTimeKind.Unspecified), 75, 50, 16 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2010, 9, 15, 19, 52, 39, 0, DateTimeKind.Unspecified), 47, 129, 9 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2010, 8, 16, 15, 17, 40, 0, DateTimeKind.Unspecified), 38, 155, 95 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2009, 8, 15, 14, 29, 11, 0, DateTimeKind.Unspecified), 16, 79, 29 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2001, 9, 24, 16, 23, 58, 0, DateTimeKind.Unspecified), 46, 181, 96 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2005, 9, 9, 18, 36, 6, 0, DateTimeKind.Unspecified), 69, 78, 84 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2003, 11, 24, 12, 54, 50, 0, DateTimeKind.Unspecified), 82, 46, 9 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2015, 9, 6, 13, 30, 24, 0, DateTimeKind.Unspecified), 60, 49, 31 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2015, 3, 26, 1, 11, 33, 0, DateTimeKind.Unspecified), 98, 76, 70 });
        }
    }
}
