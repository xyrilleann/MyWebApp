using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models
{
    public class Author : BaseModel
    {
        public Guid? UserId { get; set; }
        public User User { get; set; }

        public Guid? ResearchId { get; set; }

        public List<Research> Researches { get; set; }
            
        public string Name { get; set; }

        public AuthorStatus AuthorStatus { get; set; }
        public bool IsPublished { get; set; }
    }
}
