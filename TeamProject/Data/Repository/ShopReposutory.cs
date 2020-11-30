using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.Repository
{
    public class ShopRepository: IShop
    {
        private readonly AppDBContent appDBContent;

        public ShopRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Shop> AllShops => appDBContent.Shop;
    }
}
