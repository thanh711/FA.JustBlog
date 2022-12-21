using FA.JustBlog.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Models
{
    public class BaseEntity
    {
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public Status Status { get; set; }
    }
}
