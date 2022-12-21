using AutoMapper;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.IRepositories;
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
            var list = mapper.Map<List<PostVM>>(unitOfWork.PostRepository.GetAll());
            return View(list);
        }
    }
}
