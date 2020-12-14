using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.ViewModels
{
    public class Section2ViewModel
    {
        public Section2ViewModel()
        {
            technics = new List<Technic> { new Technic() };

            Quntity = new List<int>();
            
            place = new Place { };

        }
        public IEnumerable<Place> AllPlaces { get; set; }
        public IEnumerable<TypeTechnic> AllTypeTechnics { get; set; }
        public IEnumerable<Executor> AllExecutors { get; set; }

        public Place place { get; set; }

        public List<int> Quntity { get; set; }

        public int timeq { get; set; }
        public bool del { get; set; }

        public int delindex { get; set; }

        public int quantity { get; set; }

     

        public List<Technic> technics { get; set; }
    }
}
