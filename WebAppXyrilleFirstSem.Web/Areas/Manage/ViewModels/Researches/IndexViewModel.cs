using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Enums;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Helpers;
using WebAppXyrilleFirstSem.Web.Infrastructures.Domain.Models;

namespace WebAppXyrilleFirstSem.Web.Areas.Manage.ViewModels.Researches
{
    public class IndexViewModel
    {
        public Page<Research> Research { get; set; }

        public ResearchStatus ResearchStatus { get; set; }

        public List<ResearchStatus> ResearchStatuses
        {
            get
            {
                return Enum.GetValues(typeof(ResearchStatus)).Cast<ResearchStatus>().ToList();
            }
        }
    }
}