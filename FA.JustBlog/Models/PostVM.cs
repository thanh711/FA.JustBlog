using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FA.JustBlog.Models
{
    public class PostVM
    {
        public int Id { get; set; }

        [Display(Name = "Post title")]
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string PostContent { get; set; }

        public string UrlSlug { get; set; }


        public DateTime PostedOn { get; set; }

        public DateTime Modified { get; set; }

        public int ViewCount { get; set; }
        public int RateCount { get; set; }
        public int TotalRate { get; set; }

        public decimal Rate
        {
            get
            {
                return (decimal)TotalRate / RateCount;
            }
        }
    }
}
