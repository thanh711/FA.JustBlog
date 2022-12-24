using AutoMapper;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.IRepositories;
using FA.JustBlog.Core.Repositories;
using FA.JustBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Controllers
{
    public class PostsController : Controller
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
            var list = mapper.Map<List<PostVM>>(unitOfWork.PostRepository.GetPaging(1, 5));
            
            return View(list);
        }
        public IActionResult LastestPost()
        {
            var list = mapper.Map<List<PostVM>>(unitOfWork.PostRepository.GetLatestPost(4));


            return View(nameof(Index), list);
        }
        public IActionResult GetPostByCategory(string category)
        {
            var list = mapper.Map<List<PostVM>>(unitOfWork.PostRepository.GetPostsByCategory(category));


            return View(nameof(Index), list);
        }
        public IActionResult Details(int year, int month, string UrlSlug)
        {
            var item = mapper.Map<PostVM>(unitOfWork.PostRepository.FindPost(year, month, UrlSlug));
            if (item == null)
                return NotFound();

            return View(item);
        }
    }
}
