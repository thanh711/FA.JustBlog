using AutoMapper;
using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostsController : AdminController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public PostsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var list = mapper.Map<List<PostVM>>(unitOfWork.PostRepository.GetAll());

            return View(list);
        }
        public IActionResult Details(int year, int month, string UrlSlug)
        {
            var item = mapper.Map<PostVM>(unitOfWork.PostRepository.FindPost(year, month, UrlSlug));
            if (item == null)
                return NotFound();
            item.CategoryName = mapper.Map<CategoryVM>(unitOfWork.CategoryRepository.GetById(item.CategoryId)).Name;
            return View(item);
        }
        public IActionResult Update(int year, int month, string UrlSlug)
        {
            var item = mapper.Map<PostVM>(unitOfWork.PostRepository.FindPost(year, month, UrlSlug));
            if (item == null)
                return NotFound();

            item.PublishedList = new List<SelectListItem> {
                       new SelectListItem { Value = Publish.Publised.ToString() , Text = "Publised" },
                       new SelectListItem { Value = Publish.Unpublised.ToString() , Text = "Unpublised" },
                    };
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(PostVM post)
        {
            ModelState.Remove("CategoryName");
            ModelState.Remove("CategoryList");
            ModelState.Remove("PublishedList");
            ModelState.Remove("CategoryName");
            if (!ModelState.IsValid)
            {
                return Update(post.PostedOn.Year, post.PostedOn.Month, post.UrlSlug);
            }
            else
            {
                Post post1 = unitOfWork.PostRepository.FindPost(post.PostedOn.Year, post.PostedOn.Month, post.UrlSlug);
                post1.Title = post.Title;
                post1.ShortDescription = post.ShortDescription;
                post1.PostContent = post.PostContent;
                post1.Published = post.Published;
                post1.CategoryId = post.CategoryId;
                unitOfWork.PostRepository.Update(post1);
                unitOfWork.SaveChanges();
                return View(nameof(Details), mapper.Map<PostVM>(post1));
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PostVM post)
        {
            ModelState.Remove("Id");
            ModelState.Remove("CategoryName");
            ModelState.Remove("CategoryList");
            ModelState.Remove("RateCount");
            ModelState.Remove("PublishedList");
            ModelState.Remove("CategoryName");
            ModelState.Remove("UrlSlug");
            if (!ModelState.IsValid)
            {
                return View(post);
            }
            else
            {
                Post post1 = mapper.Map<Post>(post);
                post1.Category = null;
                post1.UrlSlug = post.Title + Guid.NewGuid();
                post1.PostedOn = DateTime.Now;
                unitOfWork.PostRepository.Create(post1);
                unitOfWork.SaveChanges();
                return View(nameof(Details), post);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            unitOfWork.PostRepository.Delete(id);
            unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
