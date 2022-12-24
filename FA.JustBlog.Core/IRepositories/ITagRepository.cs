using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.IRepositories
{
    /// <summary>
    /// Tag repository implement some basic CRUD functions
    /// </summary>
    public interface ITagRepository : IBaseRepository<Tag>
    {
        Tag GetTagByUrlSlug(string urlSlug);
        IList<Tag> GetTagByPostId(int id);
    }
}
