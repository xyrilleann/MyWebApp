using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Authors
{
    public class CreateViewModel
    {
        public Guid? ResearchId { get; set; }

        public string Name { get; set; }

        public AuthorStatus AuthorStatus { get; set; }

    }
}
