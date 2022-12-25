using FA.JustBlog.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.Models
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public virtual IList<PostVM> Posts { get; set; }
    }
}
