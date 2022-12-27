using AutoMapper;
using FA.JustBlog.Core.Constants;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Common.ViewModels;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
        public IActionResult Create(CommentVM model)
        {
            ModelState.Remove("Id");
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                Comment comment = mapper.Map<Comment>(model);
                comment.CommentTime = DateTime.Now;
                unitOfWork.CommentRepository.Create(comment);
                unitOfWork.SaveChanges();
                return View(nameof(Details), mapper.Map<CommentVM>(comment));
            }
        }

        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
        public IActionResult Update(int id)
        {
            var item = mapper.Map<CommentVM>(unitOfWork.CommentRepository.GetById(id));
            if (item == null)
                return NotFound();
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner)]
        public IActionResult Update(CommentVM model)
        {
            if (!ModelState.IsValid)
            {
                return Update(model.Id);
            }
            else
            {
                Comment comment= unitOfWork.CommentRepository.GetById(model.Id);
                comment.Name = model.Name;
                comment.Email = model.Email;
                comment.CommentHeader = model.CommentHeader;
                comment.CommentText = model.CommentText;
                unitOfWork.CommentRepository.Update(comment);
                unitOfWork.SaveChanges();
                return View(nameof(Details), mapper.Map<CommentVM>(comment));
            }
            return View();
        }

        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner + "," + Roles.User)]
        public IActionResult Details(int id)
        {
            var item = mapper.Map<CommentVM>(unitOfWork.CommentRepository.GetById(id));
            if (item == null)
                return NotFound();
            return View(item);
        }

        [Authorize(Roles = Roles.Contributor + "," + Roles.BlogOwner + "," + Roles.User)]
        public IActionResult Index()
        {
            var list = mapper.Map<List<CommentVM>>(unitOfWork.CommentRepository.GetAll());

            return View(list);
        }

        [HttpPost]
        [Authorize(Roles = Roles.BlogOwner)]
        public IActionResult Delete(int id)
        {
            unitOfWork.CommentRepository.Delete(id);
            unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
