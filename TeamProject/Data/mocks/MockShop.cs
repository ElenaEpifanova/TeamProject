using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.mocks
{
    public class MockShop : IShop
    {
        public IEnumerable<Shop> AllShops
        {
            get
            {
                return new List<Shop>
                {
                    new Shop{name="КРС (Капитальный ремонт скважин)"},
                    new Shop{name="ПРС (Подземный ремонт скважин)"}
                };
            }
        }
    }
}
