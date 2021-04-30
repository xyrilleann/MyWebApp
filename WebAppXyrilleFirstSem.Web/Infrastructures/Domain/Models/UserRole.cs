using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models
{
    public class UserRole : BaseModel
    {
        public Guid? UserId { get; set; }

        public Role Role { get; set; }
    }
}
