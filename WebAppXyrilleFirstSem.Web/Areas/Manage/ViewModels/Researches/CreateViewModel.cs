using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Researches
{
    public class CreateViewModel
    {
      
        public Guid? AuthorId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

    }
}
