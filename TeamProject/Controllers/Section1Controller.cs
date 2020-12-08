using Microsoft.AspNetCore.Mvc;
using TeamProject.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.ViewModels;
using TeamProject.Data.Models;
using Newtonsoft.Json;

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

        [HttpPost]
        public IActionResult Index(Section1ViewModel model)
        {
            model.AllShops = _allShops.AllShops;
            model.AllResponsibles = _allResponsibles.AllResponsibles;
            //--Data from model--
            int shopId = _allShops.AllShops.First(c => c.name == model.shop).Id;
            int responsibleId = _allResponsibles.FindObjectResponsible(model.responsible).Id;

            DateTime date_b = model.date_begin.AddMinutes(Convert.ToInt32(model.time_begin.Substring(0, model.time_begin.IndexOf(':'))) * 60
                                                    + Convert.ToInt32(model.time_begin.Substring(model.time_begin.IndexOf(':') + 1, 2)));

            DateTime date_e = model.date_end.AddMinutes(Convert.ToInt32(model.time_end.Substring(0, model.time_end.IndexOf(':'))) * 60
                                                   + Convert.ToInt32(model.time_end.Substring(model.time_end.IndexOf(':') + 1, 2)));

            //--New Request--
            Request request = new Request
            {
                ShopId = shopId,
                ResponsibleId = responsibleId,
                begin = date_b,
                end = date_e,
                description = model.description,
                comment = model.comment
            };
            TempData["request"] = JsonConvert.SerializeObject(request);
            return RedirectToAction("Index", "ViewRequests");
        }
    }
}
