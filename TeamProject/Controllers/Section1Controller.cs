using Microsoft.AspNetCore.Mvc;
using TeamProject.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.ViewModels;

namespace TeamProject.Controllers
{
    public class Section1Controller : Controller
    {
        private readonly IShop _allShops;
        private readonly IResponsible _allResponsibles;

        public Section1Controller(IShop iAllShops, IResponsible iAllResponsibles)
        {
            _allShops = iAllShops;
            _allResponsibles = iAllResponsibles;
        }

        public ViewResult Index()
        {
            Section1ViewModel obj = new Section1ViewModel();
            obj.AllShops = _allShops.AllShops;
            obj.AllResponsibles = _allResponsibles.AllResponsibles;

            return View(obj);
        }
    }
}
