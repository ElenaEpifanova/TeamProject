using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.ViewModels
{
    public class Section2ViewModel
    {
        public IEnumerable<Place> AllPlaces { get; set; }
        public IEnumerable<TypeTechnic> AllTypeTechnics { get; set; }
        public IEnumerable<Executor> AllExecutors { get; set; }
    }
}
