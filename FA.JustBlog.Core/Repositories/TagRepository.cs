using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Repositories
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(JustBlogContext context) : base(context)
        {
        }

        public IList<Tag> GetTagByPostId(int id)
        {
            var innerJoinQuery =
              from tag in DbSet
              join postTag in context.Set<PostTagMap>() on tag.Id equals postTag.TagId
              join post in context.Set<Post>() on postTag.PostId equals post.Id
              where post.Id == id
              where tag.Status == Status.Actived
              select tag;
            return innerJoinQuery.ToList();
        }

        public Tag GetTagByUrlSlug(string urlSlug)
        {
            return Find(t=>t.UrlSlug== urlSlug).FirstOrDefault();
        }

        
    }
}
