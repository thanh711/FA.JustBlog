
using FA.JustBlog.Core.Enum;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace FA.JustBlog.Common.ViewModels
{
    public class PostVM
    {
        public int Id { get; set; }

        [Display(Name = "Post title")]
        [Required(ErrorMessage = "Post title is required.")]
        [StringLength(255)]
        public string Title { get; set; }
       
        public string ShortDescription { get; set; }


        public string PostContent { get; set; }

        public string UrlSlug { get; set; }

        
        public DateTime PostedOn { get; set; }
        public string PostedOnTime { 
            get {
                return PostedOn.ToString("yyyy/MM/dd hh:mm:ss tt");
            } }
        public Publish Published { get; set; }
        public DateTime Modified { get; set; }

        public int ViewCount { get; set; }
        public int RateCount { get; set; }
        public int TotalRate { get; set; }
        public int CategoryId { get; set; }
        public decimal Rate
        {
            get
            {
                return (decimal)TotalRate / (RateCount == 0 ? 1 : RateCount);
            }
        }
        public string CategoryName { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
