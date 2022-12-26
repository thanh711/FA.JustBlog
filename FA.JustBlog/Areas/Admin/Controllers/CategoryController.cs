using AutoMapper;
using FA.JustBlog.Common.ViewModels;
using FA.JustBlog.Core.Constants;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
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


        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
        public IActionResult Update(int id)
        {
            var item = mapper.Map<CategoryVM>(unitOfWork.CategoryRepository.GetById(id));
            if (item == null)
                return NotFound();
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
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

        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner + "," + Roles.User)]
        public IActionResult Details(int id)
        {
            var item = mapper.Map<CategoryVM>(unitOfWork.CategoryRepository.GetById(id));
            if (item == null)
                return NotFound();
            return View(item);
        }

        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner + "," + Roles.User)]
        public IActionResult Index()
        {
            var list = mapper.Map<List<CategoryVM>>(unitOfWork.CategoryRepository.GetAll());

            return View(list);
        }
       
      
        [HttpPost]
        [Authorize(Roles = Roles.BlogOwner)]
        public IActionResult Delete(int id)
        {
            unitOfWork.CategoryRepository.Delete(id);
            unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
