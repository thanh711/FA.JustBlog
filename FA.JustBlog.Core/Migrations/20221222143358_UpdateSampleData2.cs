using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class UpdateSampleData2 : Migration
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
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 9, 1 },
                    { 13, 1 },
                    { 15, 1 },
                    { 25, 1 },
                    { 28, 1 },
                    { 29, 1 },
                    { 30, 1 },
                    { 32, 1 },
                    { 41, 1 },
                    { 45, 1 },
                    { 47, 1 },
                    { 8, 2 },
                    { 18, 2 },
                    { 23, 2 },
                    { 25, 2 },
                    { 32, 2 },
                    { 33, 2 },
                    { 34, 2 },
                    { 36, 2 },
                    { 38, 2 },
                    { 39, 2 },
                    { 40, 2 },
                    { 43, 2 },
                    { 8, 3 },
                    { 9, 3 },
                    { 13, 3 },
                    { 14, 3 },
                    { 15, 3 },
                    { 18, 3 },
                    { 20, 3 },
                    { 25, 3 },
                    { 29, 3 },
                    { 30, 3 },
                    { 33, 3 },
                    { 43, 3 },
                    { 48, 3 },
                    { 49, 3 },
                    { 2, 4 },
                    { 7, 4 },
                    { 10, 4 },
                    { 14, 4 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 16, 4 },
                    { 29, 4 },
                    { 35, 4 },
                    { 39, 4 },
                    { 40, 4 },
                    { 42, 4 },
                    { 45, 4 },
                    { 46, 4 },
                    { 8, 5 },
                    { 10, 5 },
                    { 19, 5 },
                    { 20, 5 },
                    { 27, 5 },
                    { 40, 5 },
                    { 41, 5 },
                    { 43, 5 },
                    { 46, 5 },
                    { 3, 6 },
                    { 10, 6 },
                    { 13, 6 },
                    { 17, 6 },
                    { 19, 6 },
                    { 20, 6 },
                    { 25, 6 },
                    { 31, 6 },
                    { 43, 6 },
                    { 46, 6 },
                    { 48, 6 },
                    { 49, 6 },
                    { 15, 7 },
                    { 18, 7 },
                    { 31, 7 },
                    { 34, 7 },
                    { 42, 7 },
                    { 2, 8 },
                    { 6, 8 },
                    { 8, 8 },
                    { 17, 8 },
                    { 19, 8 },
                    { 20, 8 },
                    { 27, 8 },
                    { 30, 8 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 34, 8 },
                    { 39, 8 },
                    { 40, 8 },
                    { 43, 8 },
                    { 5, 9 },
                    { 10, 9 },
                    { 14, 9 },
                    { 25, 9 },
                    { 27, 9 },
                    { 29, 9 },
                    { 35, 9 },
                    { 43, 9 },
                    { 46, 9 },
                    { 47, 9 },
                    { 12, 10 },
                    { 14, 10 },
                    { 17, 10 },
                    { 18, 10 },
                    { 20, 10 },
                    { 27, 10 },
                    { 28, 10 },
                    { 34, 10 },
                    { 41, 10 },
                    { 43, 10 },
                    { 2, 11 },
                    { 4, 11 },
                    { 12, 11 },
                    { 14, 11 },
                    { 20, 11 },
                    { 21, 11 },
                    { 31, 11 },
                    { 38, 11 },
                    { 41, 11 },
                    { 44, 11 },
                    { 48, 11 },
                    { 1, 12 },
                    { 4, 12 },
                    { 6, 12 },
                    { 15, 12 },
                    { 18, 12 },
                    { 19, 12 },
                    { 25, 12 }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 31, 12 },
                    { 32, 12 },
                    { 43, 12 },
                    { 45, 12 },
                    { 1, 13 },
                    { 9, 13 },
                    { 15, 13 },
                    { 18, 13 },
                    { 20, 13 },
                    { 27, 13 },
                    { 29, 13 },
                    { 35, 13 },
                    { 39, 13 },
                    { 41, 13 },
                    { 3, 14 },
                    { 15, 14 },
                    { 19, 14 },
                    { 27, 14 },
                    { 29, 14 },
                    { 42, 14 },
                    { 44, 14 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 32, 18, 50 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, 73, 69, 80 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, 37, 194, 76 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, 35, 115, 46 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, 23, 76, 82 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2005, 9, 25, 22, 19, 32, 0, DateTimeKind.Unspecified), 38, 59, 66 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2015, 8, 4, 2, 16, 48, 0, DateTimeKind.Unspecified), 42, 127, 66 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2017, 5, 24, 18, 23, 44, 0, DateTimeKind.Unspecified), 92, 192, 22 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2001, 2, 25, 23, 16, 13, 0, DateTimeKind.Unspecified), 98, 196, 48 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2022, 4, 13, 7, 13, 10, 0, DateTimeKind.Unspecified), 53, 169, 37 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2021, 10, 21, 0, 57, 6, 0, DateTimeKind.Unspecified), 24, 166, 98 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2001, 1, 24, 16, 11, 30, 0, DateTimeKind.Unspecified), 12, 42, 73 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2013, 7, 13, 13, 25, 17, 0, DateTimeKind.Unspecified), 7, 41, 95 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2006, 10, 26, 19, 24, 26, 0, DateTimeKind.Unspecified), 69, 72, 32 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2012, 12, 30, 15, 11, 48, 0, DateTimeKind.Unspecified), 83, 145, 70 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2019, 8, 9, 6, 53, 6, 0, DateTimeKind.Unspecified), 46, 29, 37 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2015, 11, 3, 9, 7, 27, 0, DateTimeKind.Unspecified), 77, 91, 53 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2006, 8, 27, 22, 51, 5, 0, DateTimeKind.Unspecified), 80, 56, 41 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2014, 9, 12, 4, 33, 2, 0, DateTimeKind.Unspecified), 92, 180, 95 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2013, 8, 24, 20, 26, 49, 0, DateTimeKind.Unspecified), 99, 178, 49 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2006, 10, 5, 14, 48, 27, 0, DateTimeKind.Unspecified), 56, 154, 16 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2008, 1, 10, 0, 3, 11, 0, DateTimeKind.Unspecified), 70, 191, 77 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2002, 2, 10, 16, 25, 10, 0, DateTimeKind.Unspecified), 10, 49, 22 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2021, 7, 30, 8, 58, 12, 0, DateTimeKind.Unspecified), 21, 126, 90 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2018, 5, 21, 14, 15, 2, 0, DateTimeKind.Unspecified), 1, 155, 35 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2020, 4, 18, 2, 59, 0, 0, DateTimeKind.Unspecified), 68, 193, 48 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2011, 3, 27, 10, 13, 5, 0, DateTimeKind.Unspecified), 95, 6, 47 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2012, 2, 26, 17, 15, 20, 0, DateTimeKind.Unspecified), 62, 58, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 3, new DateTime(2011, 12, 18, 5, 13, 59, 0, DateTimeKind.Unspecified), 73, 191, 73 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2009, 7, 27, 19, 58, 3, 0, DateTimeKind.Unspecified), 12, 62, 80 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2014, 8, 15, 12, 15, 10, 0, DateTimeKind.Unspecified), 15, 54, 68 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2013, 10, 25, 12, 18, 48, 0, DateTimeKind.Unspecified), 92, 92, 26 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2017, 5, 17, 7, 34, 29, 0, DateTimeKind.Unspecified), 83, 174, 10 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2012, 7, 22, 16, 35, 36, 0, DateTimeKind.Unspecified), 75, 6, 69 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2019, 12, 24, 21, 45, 14, 0, DateTimeKind.Unspecified), 51, 95, 54 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2022, 7, 10, 22, 44, 34, 0, DateTimeKind.Unspecified), 65, 145, 38 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2008, 10, 2, 15, 20, 26, 0, DateTimeKind.Unspecified), 22, 111, 69 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2003, 10, 18, 3, 16, 17, 0, DateTimeKind.Unspecified), 43, 192, 13 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2007, 8, 15, 22, 22, 37, 0, DateTimeKind.Unspecified), 29, 199, 22 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2011, 9, 9, 20, 1, 34, 0, DateTimeKind.Unspecified), 29, 84, 81 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2008, 9, 22, 2, 30, 36, 0, DateTimeKind.Unspecified), 58, 75, 88 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2020, 3, 15, 1, 37, 26, 0, DateTimeKind.Unspecified), 8, 17, 90 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 2, new DateTime(2003, 12, 11, 13, 39, 52, 0, DateTimeKind.Unspecified), 4, 110, 21 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 8, new DateTime(2015, 2, 13, 16, 17, 0, 0, DateTimeKind.Unspecified), 19, 65, 41 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 5, new DateTime(2022, 2, 5, 2, 23, 32, 0, DateTimeKind.Unspecified), 64, 22, 63 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "PostedOn", "TotalRate", "ViewCount" },
                values: new object[] { 4, new DateTime(2012, 12, 2, 6, 40, 56, 0, DateTimeKind.Unspecified), 136, 52 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2011, 11, 2, 9, 15, 34, 0, DateTimeKind.Unspecified), 40, 187, 10 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 6, new DateTime(2001, 10, 3, 8, 10, 0, 0, DateTimeKind.Unspecified), 49, 24, 75 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 7, new DateTime(2002, 6, 11, 9, 0, 45, 0, DateTimeKind.Unspecified), 40, 30, 47 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 32, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 33, 2 });

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
                keyValues: new object[] { 38, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 39, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 40, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 33, 3 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 3 });

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
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 35, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 39, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 40, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 42, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 45, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 46, 4 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 40, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 46, 5 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 31, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 46, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 48, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 49, 6 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 31, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 42, 7 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 27, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 30, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 34, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 39, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 40, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 8 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 27, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 35, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 46, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 47, 9 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 28, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 34, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 10 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 10 });

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
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 20, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 21, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 31, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 38, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 44, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 48, 11 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 19, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 25, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 31, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 32, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 43, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 45, 12 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 18, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 20, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 27, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 35, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 39, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 41, 13 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 15, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 19, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 27, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 29, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 42, 14 });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 44, 14 });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId", "CreateAt", "Status" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 58, 99, 22 });

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
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2019, 4, 30, 14, 46, 5, 0, DateTimeKind.Unspecified), 35, 138, 38 });

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
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2011, 2, 9, 7, 1, 32, 0, DateTimeKind.Unspecified), 92, 145, 89 });

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
                columns: new[] { "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2015, 11, 27, 5, 2, 18, 0, DateTimeKind.Unspecified), 94, 128, 88 });

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
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2001, 3, 12, 5, 10, 57, 0, DateTimeKind.Unspecified), 9, 81, 62 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2005, 6, 5, 5, 33, 21, 0, DateTimeKind.Unspecified), 46, 165, 28 });

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
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2008, 11, 27, 6, 51, 23, 0, DateTimeKind.Unspecified), 61, 57, 10 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2016, 6, 12, 17, 1, 1, 0, DateTimeKind.Unspecified), 95, 172, 24 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2000, 3, 3, 4, 8, 20, 0, DateTimeKind.Unspecified), 37, 131, 98 });

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
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2005, 7, 24, 21, 57, 58, 0, DateTimeKind.Unspecified), 99, 94, 30 });

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
                columns: new[] { "CategoryId", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { 1, new DateTime(2004, 2, 11, 14, 13, 10, 0, DateTimeKind.Unspecified), 1, 50, 33 });

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
                columns: new[] { "CategoryId", "PostedOn", "TotalRate", "ViewCount" },
                values: new object[] { 9, new DateTime(2022, 12, 4, 18, 11, 23, 0, DateTimeKind.Unspecified), 101, 26 });

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
    }
}
