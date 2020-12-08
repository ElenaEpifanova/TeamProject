using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.Repository
{
    public class PlaceRepository : IPlace
    {
        private readonly AppDBContent appDBContent;

        public PlaceRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Place> AllPlaces => appDBContent.Place.OrderBy(r => r.name);

    }
}
