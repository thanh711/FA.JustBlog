using AutoMapper;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : AdminController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var list = mapper.Map<List<CategoryVM>>(unitOfWork.CategoryRepository.GetAll());

            return View(list);
        }
    }
}
