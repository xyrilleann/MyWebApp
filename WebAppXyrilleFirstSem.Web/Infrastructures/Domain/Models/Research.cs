using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models
{
    public class Research : BaseModel
    {
        public Guid? AuthorId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool IsPublished { get; set; }

        public ResearchStatus ResearchStatus { get; set; }

    }
}
