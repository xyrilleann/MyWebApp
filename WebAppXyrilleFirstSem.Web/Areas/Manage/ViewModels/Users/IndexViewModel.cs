using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> User { get; set; }

        public User NewUser { get; set; }

        public UserStatus UserStatus { get; set; }

        public List<UserStatus> UserStatuses
        {
            get
            {
                return Enum.GetValues(typeof(UserStatus)).Cast<UserStatus>().ToList();
            }
        }
    }
}