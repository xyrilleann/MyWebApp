using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Researches;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Data;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppXyrilleFirstSem.Web.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ResearchesController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;

        public ResearchesController(DefaultDbContext context, IConfiguration iConfiguration)
        {
            _context = context;
            this._config = iConfiguration;



        }
        [HttpGet, Route("manage/researches")]
        [HttpGet, Route("manage/researches/index")]
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "", string status = "Available")
        {
            Enum.TryParse(status, out ResearchStatus researchStatus); ;


            Page<Research> result = new Page<Research>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Research> resQuery = (IQueryable<Research>)this._context.Researches.Where(s => s.ResearchStatus == researchStatus);

            if (string.IsNullOrEmpty(keyword) == false)
            {
                resQuery = resQuery.Where(s => s.Title.Contains(keyword)
                                                );

            }

            long queryCount = resQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Research> researches = resQuery.ToList();

            result.Items = researches.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Research = result,
                ResearchStatus = researchStatus
            });
        }
        [HttpGet, Route("manage/researches/delete/{researchId}/{authorId}")]
        public IActionResult Delete(Guid? researchId,Guid? authorId)
        {
            var author = this._context.Authors.FirstOrDefault(a => a.Id == authorId);

            var research = this._context.Researches.FirstOrDefault(s => s.Id == researchId);

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


        [HttpGet, Route("manage/researches/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var research = this._context.Researches.FirstOrDefault(m => m.Id == id);
            if (research == null)
            {
                return NotFound();
            }

            return View(research);
        }

        [HttpGet, Route("manage/researches/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("manage/researches/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Research research = new Research()
            {

                Id = Guid.NewGuid(),
                Title = model.Title,
                Description = model.Description,
                Content = model.Content,
                ResearchStatus = ResearchStatus.Available,
                IsPublished = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,



            };
            this._context.Researches.Add(research);
            this._context.SaveChanges();

            return RedirectToAction("Index");

        }


        [HttpGet, Route("manage/researches/edit/{id}")]
        public IActionResult Edit(Guid? id)
        {

            var research = this._context.Researches.FirstOrDefault(s => s.Id == id);

            if (research == null)
            {
                return RedirectToAction("Index");
            }


            if (research != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = research.Id.Value,
                        Title = research.Title,
                        Description = research.Description,
                        Content = research.Content,
                        

                    }
                );
            }

            return View();
        }
        [HttpPost, Route("manage/researches/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var research = this._context.Researches.FirstOrDefault(s => s.Id == model.Id);

            if (research != null)
            {
                research.Title = model.Title;
                research.Description = model.Description;
                research.Content = model.Content;


                this._context.Researches.Update(research);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }
    }
}