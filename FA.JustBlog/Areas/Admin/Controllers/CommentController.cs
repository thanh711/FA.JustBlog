using AutoMapper;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : AdminController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CommentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var list = mapper.Map<List<CommentVM>>(unitOfWork.CommentRepository.GetAll());

            return View(list);
        }
    }
}
