using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Users;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Data;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppXyrilleFirstSem.Web.Areas.Manage.Controllers
{
    [Area("manage")]
    public class UsersController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;

        public UsersController(DefaultDbContext context, IConfiguration iConfiguration)
        {
            _context = context;
            this._config = iConfiguration;



        }
        [HttpGet, Route("manage/users")]
        [HttpGet, Route("manage/users/index")]
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "", string status = "Active")
        {
            Enum.TryParse(status, out UserStatus userStatus); ;


            Page<User> result = new Page<User>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<User> useQuery = (IQueryable<User>)this._context.Users.Where(s => s.UserStatus == userStatus);


            if (string.IsNullOrEmpty(keyword) == false)
            {
                useQuery = useQuery.Where(s => s.FirstName.Contains(keyword)
                                                 || s.LastName.Contains(keyword)
                                                 || s.FullName.Contains(keyword)
                                                 || s.UserName.Contains(keyword));

            }

            long queryCount = useQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<User> users = useQuery.ToList();

            result.Items = users.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                User = result,
                UserStatus = userStatus
            });
        }


        [HttpGet, Route("manage/users/delete/{userId}")]
        public IActionResult Delete(Guid? userId)
        {

            var user = this._context.Users.Include(u => u.Author).FirstOrDefault(s => s.Id == userId);

            if (user != null)
            {
                this._context.Users.Remove(user);
                this._context.SaveChanges();
                
               
            }

            return RedirectToAction("index");
        }


        [HttpGet, Route("manage/users/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = this._context.Users.FirstOrDefault(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpGet, Route("manage/users/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("manage/users/create")]
        public IActionResult Create(CreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            User user = new User()
            {

                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Address = model.Address,
                EmailAddress = model.EmailAddress,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber,
                IsPublished = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,



            };
            this._context.Users.Add(user);
            this._context.SaveChanges();

            return RedirectToAction("Index");

        }


        [HttpGet, Route("manage/users/edit/{id}")]
        public IActionResult Edit(Guid? id)
        {

            var user = this._context.Users.FirstOrDefault(s => s.Id == id);

            if (user == null)
            {
                return RedirectToAction("Index");
            }


            if (user != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = user.Id.Value,
                        FirstName = user.LastName,
                        LastName = user.LastName,
                        Address = user.Address,
                        EmailAddress = user.EmailAddress,
                        Password = user.Password,
                        PhoneNumber = user.Password,
                        UserName = user.UserName

                    }
                );
            }

            return View();
        }
        [HttpPost, Route("manage/users/edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = this._context.Users.FirstOrDefault(s => s.Id == model.Id);

            if (user != null)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.UserName = model.UserName;
                user.Address = model.Address;
                user.PhoneNumber = model.PhoneNumber;
                user.EmailAddress = model.EmailAddress;
                user.Password = model.Password;


                this._context.Users.Update(user);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }


        [HttpGet, Route("manage/users/logout/{userId}")]
        public IActionResult Logout(Guid? userId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                WebUser.UserId = null;
                WebUser.UserName = null;
            }
            return Redirect("~/home/index");
        }
    }
}
