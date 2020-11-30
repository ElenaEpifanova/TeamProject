using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.Data.interfaces
{
    public interface IPlace
    {
        IEnumerable<Place> AllPlaces { get; }
    }
}
