using AutoMapper;
using FA.JustBlog.Core.Enum;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;

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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryVM model)
        {
            ModelState.Remove("Id");
            ModelState.Remove("Posts");
            ModelState.Remove("UrlSlug");
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                Category category = mapper.Map<Category>(model);
                category.UrlSlug = model.Name + Guid.NewGuid();
                unitOfWork.CategoryRepository.Create(category);
                unitOfWork.SaveChanges();
                return View(nameof(Details), mapper.Map<CategoryVM>(category));
            }
        }
        public IActionResult Index()
        {
            var list = mapper.Map<List<CategoryVM>>(unitOfWork.CategoryRepository.GetAll());

            return View(list);
        }

        public IActionResult Details(int id)
        {
            var item = mapper.Map<CategoryVM>(unitOfWork.CategoryRepository.GetById(id));
            if (item == null)
                return NotFound();
            return View(item);
        }
        public IActionResult Update(int id)
        {
            var item = mapper.Map<CategoryVM>(unitOfWork.CategoryRepository.GetById(id));
            if (item == null)
                return NotFound();
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(CategoryVM model)
        {
            ModelState.Remove("Posts");
            if (!ModelState.IsValid)
            {
                return Update(model.Id);
            }
            else
            {
                Category category = unitOfWork.CategoryRepository.GetById(model.Id);
                category.Name = model.Name;
                category.Description = model.Description;
                unitOfWork.CategoryRepository.Update(category);
                unitOfWork.SaveChanges();
                return View(nameof(Details), mapper.Map<CategoryVM>(category));
            }
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            unitOfWork.CategoryRepository.Delete(id);
            unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
