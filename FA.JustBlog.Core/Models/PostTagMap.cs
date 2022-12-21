using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Models
{
    public class PostTagMap : BaseEntity
    {
        [ForeignKey("Tag")]
        public int TagId { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }

        public virtual Tag Tag { get; set; }

        public virtual Post Post { get; set; }
    }
}
