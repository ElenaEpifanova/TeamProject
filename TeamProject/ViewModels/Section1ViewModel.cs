using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.ViewModels
{
    public class Section1ViewModel
    {
        public Section1ViewModel()
        {
            request = new Request();

        }
        public IEnumerable<Shop> AllShops { get; set; }
        public IEnumerable<Responsible> AllResponsibles { get; set; }

        public Request request { get; set; }
        public string time_begin { get; set; }
        public string time_end { get; set; }
        public string editing { get; set; }

    }
}
