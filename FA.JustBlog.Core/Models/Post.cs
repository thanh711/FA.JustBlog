using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FA.JustBlog.Core.Enum;

namespace FA.JustBlog.Core.Models
{
    public class Post : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Post title is required.")]
        [StringLength(255)]
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Post content is required.")]
        public string PostContent { get; set; }

        [StringLength(255)]
        public string UrlSlug { get; set; }

        public Publish Published { get; set; }

        [Required(ErrorMessage = "Post PostedOn is required.")]
        public DateTime PostedOn { get; set; }

        public DateTime Modified { get; set; }

        public int ViewCount { get; set; }
        public int RateCount { get; set; }
        public int TotalRate { get; set; }

        [NotMapped]
        public decimal Rate { get {
                return (decimal)TotalRate / (RateCount==0?1: RateCount);
            } }

        [ForeignKey("Categorys")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public virtual ICollection<PostTagMap> PostTagMaps { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
