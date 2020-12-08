using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.ViewModels
{
    public class Section1ViewModel
    {
        public IEnumerable<Shop> AllShops { get; set; }
        public IEnumerable<Responsible> AllResponsibles { get; set; }
        public DateTime date_begin { get; set; }
        public DateTime date_end { get; set; }
        public string comment { get; set; }
        public string description { get; set; }
        public string shop { get; set; }
        public string responsible { get; set; }
        public string time_begin { get; set; }
        public string time_end { get; set; }

    }
}
