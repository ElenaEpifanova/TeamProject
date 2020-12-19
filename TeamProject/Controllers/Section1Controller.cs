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
            object request;
            TempData.TryGetValue("request", out request);
            if (request != null)
            {
                request = JsonConvert.DeserializeObject<Request>((string)request);
                obj.request = request as Request;
                TempData["request"] = JsonConvert.SerializeObject(obj.request, Formatting.None,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                obj.editing = Convert.ToString(TempData["editing"]);
                TempData["editing"] = obj.editing;
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Index(Section1ViewModel model)
        {
            model.AllShops = _allShops.AllShops;
            model.AllResponsibles = _allResponsibles.AllResponsibles;
            //--Data from model--
            DateTime date_b = model.request.begin.AddMinutes(Convert.ToInt32(model.time_begin.Substring(0, model.time_begin.IndexOf(':'))) * 60
                                                    + Convert.ToInt32(model.time_begin.Substring(model.time_begin.IndexOf(':') + 1, 2)));

            DateTime date_e = model.request.end.AddMinutes(Convert.ToInt32(model.time_end.Substring(0, model.time_end.IndexOf(':'))) * 60
                                                   + Convert.ToInt32(model.time_end.Substring(model.time_end.IndexOf(':') + 1, 2)));
            //--update request--
            model.request.Shop = _allShops.AllShops.First(s => s.Id == model.request.ShopId);
            model.request.Responsible = _allResponsibles.AllResponsibles.First(s => s.Id == model.request.ResponsibleId);
            model.request.begin = date_b;
            model.request.end = date_e;

            //--get technics--
            object request;
            TempData.TryGetValue("request", out request);
            if (request != null)
            {
                request = JsonConvert.DeserializeObject<Request>((string)request);
                Request tmp = request as Request;
                model.request.technic = tmp.technic;
                model.request.PlaceId = tmp.PlaceId;
                model.request.Place = tmp.Place;
            }
            model.editing = Convert.ToString(TempData["editing"]);
            //--post--
            TempData["request"] = JsonConvert.SerializeObject(model.request, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });


            if (model.editing == "home")
                return RedirectToAction("Supply", "Home");
            else
                return RedirectToAction("Index", "Section2");
        }
    }
}
