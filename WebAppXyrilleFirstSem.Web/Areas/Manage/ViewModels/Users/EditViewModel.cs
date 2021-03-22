using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Users
{
    public class EditViewModel
    {
        public Guid? Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }


        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public UserStatus UserStatus { get; set; }


    }

}
