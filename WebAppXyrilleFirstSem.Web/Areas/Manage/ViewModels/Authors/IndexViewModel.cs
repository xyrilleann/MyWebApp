using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Authors
{
    public class IndexViewModel
    {
        public Page<Author> Author { get; set; }

        public AuthorStatus AuthorStatus { get; set; }

        public List<AuthorStatus> AuthorStatuses
        {
            get
            {
                return Enum.GetValues(typeof(AuthorStatus)).Cast<AuthorStatus>().ToList();
            }
        }
    }
}