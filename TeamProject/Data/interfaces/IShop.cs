using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.Data.interfaces
{
    public interface IShop
    {
        IEnumerable<Shop> AllShops { get; }
    }
}
