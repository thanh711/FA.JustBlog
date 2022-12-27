using AutoMapper;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Common.ViewModels;
using Microsoft.AspNetCore.Mvc;
using FA.JustBlog.Core.Constants;
using FA.JustBlog.Core.Models;
using Microsoft.AspNetCore.Authorization;

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
        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
        public IActionResult Create(TagVM model)
        {
            ModelState.Remove("Id");
            ModelState.Remove("Count");
            ModelState.Remove("UrlSlug");
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                Tag tag = mapper.Map<Tag>(model);
                tag.UrlSlug = model.Name + Guid.NewGuid();
                unitOfWork.TagRepository.Create(tag);
                unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
        }


        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
        public IActionResult Update(int id)
        {
            var item = mapper.Map<TagVM>(unitOfWork.TagRepository.GetById(id));
            if (item == null)
                return NotFound();
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
        public IActionResult Update(TagVM model)
        {
            ModelState.Remove("Count");
            if (!ModelState.IsValid)
            {
                return Update(model.Id);
            }
            else
            {
                Tag tag = unitOfWork.TagRepository.GetById(model.Id);
                tag.Name = model.Name;
                tag.Description = model.Description;
                unitOfWork.TagRepository.Update(tag);
                unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner + "," + Roles.User)]
        public IActionResult Details(int id)
        {
            var item = mapper.Map<TagVM>(unitOfWork.TagRepository.GetById(id));
            if (item == null)
                return NotFound();
            return View(item);
        }

        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner + "," + Roles.User)]
        public IActionResult Index()
        {
            var list = mapper.Map<List<TagVM>>(unitOfWork.TagRepository.GetAll());

            return View(list);
        }

        [HttpPost]
        [Authorize(Roles = Roles.BlogOwner)]
        public IActionResult Delete(int id)
        {
            unitOfWork.TagRepository.Delete(id);
            unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
