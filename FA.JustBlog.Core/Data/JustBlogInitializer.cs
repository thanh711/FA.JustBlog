using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Data
{
    public static class JustBlogInitializer
    {
        /// <summary>
        /// init some sample data
        /// </summary>
        /// <param name="builder"></param>
        public static void Seed(this ModelBuilder builder)
        {
            #region Init Category Data
            List<Category> categories = new List<Category>();
            for(int i = 1; i < 10; i++)
            {
                categories.Add(new Category
                {
                    Id = i,
                    Name = "Category Name "+i,
                    UrlSlug = "Category UrlSlug " + i,
                    Description = "Category Description " + i,
                });
            }
            builder.Entity<Category>().HasData(categories);
           
         
            #endregion

            #region Init Post Data
            builder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "Post Title demo:" + 1,
                    ShortDescription = "Post ShortDescription demo:" + 1,
                    PostContent = "Post PostContent demo:" + 1,
                    UrlSlug = "Post UrlSlug demo:" + 1,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 1, 1),
                    Modified = new DateTime(2020, 11, 1),
                    CategoryId = 1,

                },
                new Post
                {
                    Id = 2,
                    Title = "Post Title demo:" + 2,
                    ShortDescription = "Post ShortDescription demo:" + 2,
                    PostContent = "Post PostContent demo:" + 2,
                    UrlSlug = "Post UrlSlug demo:" + 2,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 1, 2),
                    Modified = new DateTime(2020, 11, 2),
                    CategoryId = 1,

                },
                new Post
                {
                    Id = 3,
                    Title = "Post Title demo:" + 3,
                    ShortDescription = "Post ShortDescription demo:" + 3,
                    PostContent = "Post PostContent demo:" + 3,
                    UrlSlug = "Post UrlSlug demo:" + 3,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 2, 3),
                    Modified = new DateTime(2020, 11, 3),
                    CategoryId = 1,

                },
                new Post
                {
                    Id = 4,
                    Title = "Post Title demo:" + 4,
                    ShortDescription = "Post ShortDescription demo:" + 4,
                    PostContent = "Post PostContent demo:" + 4,
                    UrlSlug = "Post UrlSlug demo:" + 4,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 3, 4),
                    Modified = new DateTime(2020, 11, 4),
                    CategoryId = 1,

                },
                new Post
                {
                    Id = 5,
                    Title = "Post Title demo:" + 5,
                    ShortDescription = "Post ShortDescription demo:" + 5,
                    PostContent = "Post PostContent demo:" + 5,
                    UrlSlug = "Post UrlSlug demo:" + 5,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 2, 5),
                    Modified = new DateTime(2020, 11, 5),
                    CategoryId = 2,

                },
                new Post
                {
                    Id = 6,
                    Title = "Post Title demo:" + 6,
                    ShortDescription = "Post ShortDescription demo:" + 6,
                    PostContent = "Post PostContent demo:" + 6,
                    UrlSlug = "Post UrlSlug demo:" + 6,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 4, 6),
                    Modified = new DateTime(2020, 11, 6),
                    CategoryId = 2,

                },
                new Post
                {
                    Id = 7,
                    Title = "Post Title demo:" + 7,
                    ShortDescription = "Post ShortDescription demo:" + 7,
                    PostContent = "Post PostContent demo:" + 7,
                    UrlSlug = "Post UrlSlug demo:" + 7,
                    Published = Publish.Unpublised,
                    PostedOn = new DateTime(2020, 5, 7),
                    Modified = new DateTime(2020, 11, 7),
                    CategoryId = 3,

                },
                new Post
                {
                    Id = 8,
                    Title = "Post Title demo:" + 8,
                    ShortDescription = "Post ShortDescription demo:" + 8,
                    PostContent = "Post PostContent demo:" + 8,
                    UrlSlug = "Post UrlSlug demo:" + 8,
                    Published = Publish.Unpublised,
                    PostedOn = new DateTime(2020, 6, 8),
                    Modified = new DateTime(2020, 11, 8),
                    CategoryId = 4,

                },
                new Post
                {
                    Id = 9,
                    Title = "Post Title demo:" + 9,
                    ShortDescription = "Post ShortDescription demo:" + 9,
                    PostContent = "Post PostContent demo:" + 9,
                    UrlSlug = "Post UrlSlug demo:" + 9,
                    Published = Publish.Unpublised,
                    PostedOn = new DateTime(2020, 7, 9),
                    Modified = new DateTime(2020, 11, 9),
                    CategoryId = 4,

                });
            #endregion

            #region Init Tag Data
            builder.Entity<Tag>().HasData(
               new Tag
               {
                   Id = 1,
                   Name = "Tag Name demo:" + 1,
                   UrlSlug = "Tag UrlSlug demo:" + 1,
                   Description = "Tag Description demo:" + 1,
                   Count = 1
               },
                new Tag
                {
                    Id = 2,
                    Name = "Tag Name demo:" + 2,
                    UrlSlug = "Tag UrlSlug demo:" + 2,
                    Description = "Tag Description demo:" + 2,
                    Count = 2
                },
                new Tag
                {
                    Id = 3,
                    Name = "Tag Name demo:" + 3,
                    UrlSlug = "Tag UrlSlug demo:" + 3,
                    Description = "Tag Description demo:" + 3,
                    Count = 3
                },
                new Tag
                {
                    Id = 4,
                    Name = "Tag Name demo:" + 4,
                    UrlSlug = "Tag UrlSlug demo:" + 4,
                    Description = "Tag Description demo:" + 4,
                    Count = 4
                },
                new Tag
                {
                    Id = 5,
                    Name = "Tag Name demo:" + 5,
                    UrlSlug = "Tag UrlSlug demo:" + 5,
                    Description = "Tag Description demo:" + 5,
                    Count = 5
                },
                new Tag
                {
                    Id = 6,
                    Name = "Tag Name demo:" + 6,
                    UrlSlug = "Tag UrlSlug demo:" + 6,
                    Description = "Tag Description demo:" + 6,
                    Count = 6
                },
                new Tag
                {
                    Id = 7,
                    Name = "Tag Name demo:" + 7,
                    UrlSlug = "Tag UrlSlug demo:" + 7,
                    Description = "Tag Description demo:" + 7,
                    Count = 7
                },
                new Tag
                {
                    Id = 8,
                    Name = "Tag Name demo:" + 8,
                    UrlSlug = "Tag UrlSlug demo:" + 8,
                    Description = "Tag Description demo:" + 8,
                    Count = 8
                },
                new Tag
                {
                    Id = 9,
                    Name = "Tag Name demo:" + 9,
                    UrlSlug = "Tag UrlSlug demo:" + 9,
                    Description = "Tag Description demo:" + 9,
                    Count = 9
                }
                );
            #endregion

            #region Init PostTagMap Data
            builder.Entity<PostTagMap>().HasData(
                new PostTagMap { PostId = 1, TagId = 1 },
            new PostTagMap { PostId = 1, TagId = 2 },
            new PostTagMap { PostId = 1, TagId = 3, },
            new PostTagMap { PostId = 2, TagId = 1 },
            new PostTagMap { PostId = 2, TagId = 2,},
            new PostTagMap { PostId = 3, TagId = 3 },
            new PostTagMap { PostId = 4, TagId = 1 },
            new PostTagMap { PostId = 5, TagId = 5 }
                );
            #endregion
        }
    }
}
