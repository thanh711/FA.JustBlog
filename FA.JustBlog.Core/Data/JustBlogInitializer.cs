using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            var rand = new Random();
        
            int postIdCount = 50;

            #region Init Category Data
            List<Category> categories = new List<Category>();
            for (int i = 1; i < 20; i++)
            {
                categories.Add(new Category
                {
                    Id = i,
                    Name = "Category " + i,
                    UrlSlug = "category-urlslug " + i,
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
                    Title = "Ukraine's Zelenskiy tells U.S. Congress aid is 'not charity', urges more support",
                    ShortDescription = "President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.",
                    PostContent = "WASHINGTON/KYIV, Dec 22 (Reuters) - President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.\r\n\r\nZelenskiy's comments on Wednesday come as Republicans - some of whom have voiced increasing scepticism about sending so much aid to Ukraine - are set to take control of the U.S. House of Representatives from Democrats on Jan. 3.",
                    UrlSlug = "post-urlslug-demo" + 1,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 1, 1),
                    Modified = new DateTime(2020, 11, 1),
                    CategoryId = rand.Next(1, 10),
                    RateCount = rand.Next(1, 100),
                    ViewCount = rand.Next(1, 100),
                    TotalRate = rand.Next(1, 200),

                },
                new Post
                {
                    Id = 2,
                    Title = "How 2022 shocked, rocked and rolled global markets",
                    ShortDescription = "LONDON, Dec 22 (Reuters) - Trillions of dollars wiped off world stocks, bond market tantrums, whip-sawing currency and commodities and the collapse of a few crypto empires - 2022 has been perhaps the most turbulent year investors have ever seen, and for good reason",
                    PostContent = "LONDON, Dec 22 (Reuters) - Trillions of dollars wiped off world stocks, bond market tantrums, whip-sawing currency and commodities and the collapse of a few crypto empires - 2022 has been perhaps the most turbulent year investors have ever seen, and for good reason.\r\n\r\nTallying the final numbers is useful but doesn't even come close to telling the whole story.\r\n\r\nYes, global equities are down $14 trillion and heading for their second worst year on record, but there have been nearly 300 interest rate hikes and a trio of 10%-plus rallies in that time making the volatility freakish.",
                    UrlSlug = "post-urlslug-demo" + 2,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 1, 2),
                    Modified = new DateTime(2020, 11, 2),
                    CategoryId = rand.Next(1, 10),
                    RateCount = rand.Next(1, 100),
                    ViewCount = rand.Next(1, 100),
                    TotalRate = rand.Next(1, 200),

                },
                new Post
                {
                    Id = 3,
                    Title = "Banker bonuses go from boom to bust in jarring reversal",
                    ShortDescription = "NEW YORK/LONDON, Dec 22 (Reuters) - Bankers in New York and London are bracing for year-end bonuses that recruiters estimate are 30% to 50% lower, while some may receive none at all as dealmaking sputters and economic gloom sets takes hold.",
                    PostContent = "Post PostContent demo:",
                    UrlSlug = "post-urlslug-demo" + 3,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 2, 3),
                    Modified = new DateTime(2020, 11, 3),
                    CategoryId = rand.Next(1, 10),
                    RateCount = rand.Next(1, 100),
                    ViewCount = rand.Next(1, 100),
                    TotalRate = rand.Next(1, 200),

                },
                new Post
                {
                    Id = 4,
                    Title = "Has green hydrogen sprung a leak?",
                    ShortDescription = "A general view of hydrogen electrolysis plant called 'REFHYNE', one of the world's first green hydrogen plants, during a launch event at Shell's Rhineland refinery in Wesseling near Cologne, Germany, July 2, 2021. REUTERS/Thilo Schmuelgen",
                    PostContent = "A general view of hydrogen electrolysis plant called 'REFHYNE', one of the world's first green hydrogen plants, during a launch event at Shell's Rhineland refinery in Wesseling near Cologne, Germany, July 2, 2021. REUTERS/Thilo Schmuelgen.A general view of hydrogen electrolysis plant called 'REFHYNE', one of the world's first green hydrogen plants, during a launch event at Shell's Rhineland refinery in Wesseling near Cologne, Germany, July 2, 2021. REUTERS/Thilo Schmuelgen",
                    UrlSlug = "post-urlslug-demo" + 4,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 3, 4),
                    Modified = new DateTime(2020, 11, 4),
                    CategoryId = rand.Next(1, 10),
                    RateCount = rand.Next(1, 100),
                    ViewCount = rand.Next(1, 100),
                    TotalRate = rand.Next(1, 200),

                },
                new Post
                {
                    Id = 5,
                    Title = "Toshiba's preferred bidder to seal $10.6 bln loan deal this week -Yomiuri",
                    ShortDescription = "President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.",
                    PostContent = "President Volodymyr Zelenskiy told the U.S. Congress that aid to Ukraine was an investment in democracy and \"not charity\" as he invoked American battles against the Nazis in World War Two to press for more assistance for his country's war effort.",
                    UrlSlug = "post-urlslug-demo" + 5,
                    Published = Publish.Publised,
                    PostedOn = new DateTime(2020, 2, 5),
                    Modified = new DateTime(2020, 11, 5),
                    CategoryId = rand.Next(1, 10),
                    RateCount = rand.Next(1, 100),
                    ViewCount = rand.Next(1, 100),
                    TotalRate = rand.Next(1, 200),
                }
                );


            List<Post> posts = new List<Post>();
            for (int i = 6; i < postIdCount; i++)
            {
                posts.Add(new Post
                {
                    Id = i,
                    Title = "Post Title demo:" + i,
                    ShortDescription = "Post ShortDescription demo:" + i,
                    PostContent = "Post PostContent demo:" + i,
                    UrlSlug = "post-urlslug-demo" + i,
                    Published = Publish.Publised,
                    PostedOn = GenerateRandomDate(),
                    CategoryId = rand.Next(1, 10),
                    RateCount = rand.Next(1,100),
                    ViewCount = rand.Next(1, 100),
                    TotalRate = rand.Next(1, 200),
                });
            }
            for (int i = postIdCount; i < postIdCount+5; i++)
            {
                posts.Add(new Post
                {
                    Id = i,
                    Title = "Post Title demo:" + i,
                    ShortDescription = "Post ShortDescription demo:" + i,
                    PostContent = "Post PostContent demo:" + i,
                    UrlSlug = "post-urlslug-demo" + i,
                    Published = Publish.Unpublised,
                    PostedOn = GenerateRandomDate(),
                    CategoryId = rand.Next(1, 10),
                    RateCount = rand.Next(1, 100),
                    ViewCount = rand.Next(1, 100),
                    TotalRate = rand.Next(1, 200),
                });
            }
            builder.Entity<Post>().HasData(posts);
            #endregion

            #region Init Tag Data
            builder.Entity<Tag>().HasData(
               new Tag
               {
                   Id = 1,
                   Name = "instagram",
                   UrlSlug = "tag-urlslug-demo" + 1,
                   Description = "Tag Description demo:" + 1,
                   Count = 1
               },
                new Tag
                {
                    Id = 2,
                    Name = "love",
                    UrlSlug = "tag-urlslug-demo" + 2,
                    Description = "Tag Description demo:" + 2,
                    Count = 2
                },
                new Tag
                {
                    Id = 3,
                    Name = "like",
                    UrlSlug = "tag-urlslug-demo" + 3,
                    Description = "Tag Description demo:" + 3,
                    Count = 3
                },
                new Tag
                {
                    Id = 4,
                    Name = "instagood",
                    UrlSlug = "tag-urlslug-demo" + 4,
                    Description = "Tag Description demo:" + 4,
                    Count = 4
                },
                new Tag
                {
                    Id = 5,
                    Name = "follow",
                    UrlSlug = "tag-urlslug-demo" + 5,
                    Description = "Tag Description demo:" + 5,
                    Count = 5
                },
                new Tag
                {
                    Id = 6,
                    Name = "likeforlikes",
                    UrlSlug = "tag-urlslug-demo" + 6,
                    Description = "Tag Description demo:" + 6,
                    Count = 6
                },
                new Tag
                {
                    Id = 7,
                    Name = "viral",
                    UrlSlug = "tag-urlslug-demo" + 7,
                    Description = "Tag Description demo:" + 7,
                    Count = 7
                },
                new Tag
                {
                    Id = 8,
                    Name = "new",
                    UrlSlug = "tag-urlslug-demo" + 8,
                    Description = "Tag Description demo:" + 8,
                    Count = 8
                },
                new Tag
                {
                    Id = 9,
                    Name = "photography",
                    UrlSlug = "tag-urlslug-demo" + 9,
                    Description = "Tag Description demo:" + 9,
                    Count = 9
                }
                ,
                new Tag
                {
                    Id = 10,
                    Name = "meme",
                    UrlSlug = "tag-urlslug-demo" + 10,
                    Description = "Tag Description demo:" + 10,
                    Count = 91
                }
                ,
                new Tag
                {
                    Id = 11,
                    Name = "girl",
                    UrlSlug = "tag-urlslug-demo" + 11,
                    Description = "Tag Description demo:" + 11,
                    Count = 92
                }
                ,
                new Tag
                {
                    Id = 12,
                    Name = "explorepage",
                    UrlSlug = "tag-urlslug-demo" + 12,
                    Description = "Tag Description demo:" + 12,
                    Count = 93
                }
                ,
                new Tag
                {
                    Id = 13,
                    Name = "india",
                    UrlSlug = "tag-urlslug-demo" + 13,
                    Description = "Tag Description demo:" + 13,
                    Count = 94
                }
                ,
                new Tag
                {
                    Id = 14,
                    Name = "new",
                    UrlSlug = "tag-urlslug-demo" + 14,
                    Description = "Tag Description demo:" + 14,
                    Count = 95
                }
                ,
                new Tag
                {
                    Id = 15,
                    Name = "car",
                    UrlSlug = "tag-urlslug-demo" + 15,
                    Description = "Tag Description demo:" + 15,
                    Count = 96
                }
                );
            #endregion

            #region Init PostTagMap Data

            List<PostTagMap> postTagMap = new List<PostTagMap>();

            for (int i = 1; i < 150; i++)
            {
                postTagMap.Add(new PostTagMap { PostId = rand.Next(1, postIdCount) });
            }
            foreach (PostTagMap postTag in postTagMap)
            {
                int tagId;
                bool isExist = true;

                while (isExist)
                {
                    tagId = rand.Next(1,15);
                    isExist = false;

                    foreach (PostTagMap postTag1 in postTagMap)
                    {
                        if (postTag1.PostId == postTag.PostId && postTag1.TagId == tagId)
                        {
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist)
                    {
                        postTag.TagId = tagId;
                    }
                }
            }
            builder.Entity<PostTagMap>().HasData(postTagMap);
            #endregion
        }

        public static DateTime GenerateRandomDate(DateTime start)
        {
            var rand = new Random();
            TimeSpan interval = DateTime.Now - start;
            if (interval < TimeSpan.Zero)
                return start;
            DateTime dateTime = start.AddDays(rand.Next(interval.Days - 1))
                .AddSeconds(rand.Next(86400));
            return dateTime;
        }
        public static DateTime GenerateRandomDate()
        {
            DateTime dateTime = new DateTime(2000, 1, 1);
            return GenerateRandomDate(dateTime);
        }
    }
}
