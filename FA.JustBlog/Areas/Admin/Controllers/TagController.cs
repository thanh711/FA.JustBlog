using AutoMapper;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Common.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TagController : AdminController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public TagController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var list = mapper.Map<List<TagVM>>(unitOfWork.TagRepository.GetAll());

            return View(list);
        }
    }
}
