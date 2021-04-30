using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models
{
    public class User : BaseModel
    {

        public User()
        {
            this.UserStatus = UserStatus.InActive;
            this.FullName = FirstName + LastName;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public UserStatus UserStatus { get; set; }

        public Role Role { get; set; }

        public LoginStatus LoginStatus { get; set; }

        public Gender Gender { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public int LoginRetries { get; set; }

        public bool IsPublished { get; set; }

        public Author Author { get; set; }
    }
}
