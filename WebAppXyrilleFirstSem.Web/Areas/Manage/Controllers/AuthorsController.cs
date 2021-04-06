using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Authors;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Data;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppXyrilleFirstSem.Web.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AuthorsController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;

        public AuthorsController(DefaultDbContext context, IConfiguration iConfiguration)
        {
            _context = context;
            this._config = iConfiguration;



        }
        [HttpGet, Route("manage/authors")]
        [HttpGet, Route("manage/authors/index")]
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "", string status = "Active")
        {
            Enum.TryParse(status, out AuthorStatus authorStatus); ;


            Page<Author> result = new Page<Author>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Author> authQuery = (IQueryable<Author>)this._context.Authors.Where(s => s.AuthorStatus == authorStatus);

            if (string.IsNullOrEmpty(keyword) == false)
            {
                authQuery = authQuery.Where(s => s.Name.Contains(keyword)
                                                );

            }

            long queryCount = authQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Author> authors = authQuery.ToList();

            result.Items = authors.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Author = result,
                AuthorStatus = authorStatus
            });
        }
        [HttpGet, Route("manage/authors/delete/{authorId}/{researchId}")]
        public IActionResult Delete(Guid? authorId, Guid? researchId)
        {
            var research = this._context.Researches.FirstOrDefault(a => a.Id == researchId);
            var author = this._context.Authors.FirstOrDefault(s => s.Id == authorId);

            if (research != null)
            {

                this._context.Researches.Remove(research);
                this._context.SaveChanges();
                
                if(author != null)
                {

                    this._context.Authors.Remove(author);
                    this._context.SaveChanges();
                }
            }

            return RedirectToAction("index");
        }


        [HttpGet, Route("manage/authors/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = this._context.Authors.FirstOrDefault(m => m.Id == id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        [HttpGet, Route("manage/authors/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("manage/authors/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Author author = new Author()
            {

                Id = Guid.NewGuid(),
                Name = model.Name,
                IsPublished = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,



            };
            this._context.Authors.Add(author);
            this._context.SaveChanges();

            return RedirectToAction("Index");

        }


        [HttpGet, Route("manage/authors/edit/{id}")]
        public IActionResult Edit(Guid? id)
        {

            var author = this._context.Authors.FirstOrDefault(s => s.Id == id);

            if (author == null)
            {
                return RedirectToAction("Index");
            }


            if (author != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = author.Id.Value,
                        Name = author.Name,
                        AuthorStatus = author.AuthorStatus,
                     


                    }
                );
            }

            return View();
        }
        [HttpPost, Route("manage/authors/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var author = this._context.Authors.FirstOrDefault(s => s.Id == model.Id);

            if (author != null)
            {
                author.Name = model.Name;
                author.AuthorStatus = model.AuthorStatus;


                this._context.Authors.Update(author);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }
    }
}