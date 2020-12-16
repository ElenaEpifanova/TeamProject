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
    public class Section2Controller : Controller
    {
        private readonly IPlace _allPlaces;
        private readonly ITypeTechnic _allTypeTechnics;
        private readonly IExecutor _allExecutors;

        public Section2Controller(IPlace iAllPlaces, ITypeTechnic iAllTypeTechnics, IExecutor iAllExecutors)
        {
            _allPlaces = iAllPlaces;
            _allTypeTechnics = iAllTypeTechnics;
            _allExecutors = iAllExecutors;
        }

        public ActionResult Index()
        {
            Section2ViewModel obj = new Section2ViewModel();

            // - get Request -
            object request;
            try
            {
                TempData.TryGetValue("request", out request);
                request = JsonConvert.DeserializeObject<Request>((string)request);
                Request req = request as Request;
                obj.timeq = ((Convert.ToInt32(req.end.Day - req.begin.Day + 1) * 12) - (req.begin.Hour - 8) - (20 - req.end.Hour)) * 2;
                TempData["request"] = JsonConvert.SerializeObject(request, Formatting.None,
                       new JsonSerializerSettings()
                       {
                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                       });

            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Section1");
            }

            obj.AllPlaces = _allPlaces.AllPlaces;
            obj.AllTypeTechnics = _allTypeTechnics.AllType.OrderBy(t => t.Id);
            obj.AllExecutors = _allExecutors.AllExecutors;

            // - Quntity -
            if (obj.Quntity.Count == 0)
                for (int i = 0; i < _allTypeTechnics.AllType.Count(); i++)
                    obj.Quntity.Add(obj.AllTypeTechnics.ElementAt(i).quantity);

            //
            obj.technics[0].TypeTechnic = _allTypeTechnics.AllType.First();
            obj.technics[0].TypeTechnicId = obj.technics[0].TypeTechnic.Id;
            obj.technics[0].Executor = _allExecutors.AllExecutors.First();

            return View(obj);
        }


        [HttpPost]
        public IActionResult Index(Section2ViewModel obj, bool res = false)
        {
            obj.AllPlaces = _allPlaces.AllPlaces;
            obj.AllTypeTechnics = _allTypeTechnics.AllType.OrderBy(t => t.Id);
            obj.AllExecutors = _allExecutors.AllExecutors;

            if (!res)
            {
                // - Quntity -
                if (obj.Quntity.Count == 0)
                    for (int i = 0; i < _allTypeTechnics.AllType.Count(); i++)
                        obj.Quntity.Add(obj.AllTypeTechnics.ElementAt(i).quantity);


                // - Add/Del block -
                if (obj.del)
                {
                    obj.quantity--;
                    obj.technics.RemoveAt(obj.delindex);
                }
                else if (obj.quantity < _allTypeTechnics.AllType.Count()) obj.quantity++;
                if (obj.quantity < 1) obj.quantity = 1;

                while (obj.technics.Count < obj.quantity) obj.technics.Add(new Technic { TypeTechnic = _allTypeTechnics.AllType.ElementAt(obj.technics.Count), Executor = _allExecutors.AllExecutors.First() });
            }

            // - Place -
            Place pl = _allPlaces.AllPlaces.First(p => p.Id == obj.place.Id);
            obj.place = pl;

            // - TypeTechnic -
            for (int i = 0; i < obj.technics.Count; i++)
            {
                TypeTechnic tmp = _allTypeTechnics.AllType.First(C => C.Id == obj.technics[i].TypeTechnic.Id);
                obj.technics[i].TypeTechnic = tmp;
                obj.technics[i].TypeTechnicId = tmp.Id;

            }

            // - Executor -
            for (int i = 0; i < obj.technics.Count; i++)
            {
                Executor temp = _allExecutors.AllExecutors.First(C => C.Id == obj.technics[i].Executor.Id);
                obj.technics[i].Executor = temp;
                obj.technics[i].ExecutorId = temp.Id;
            }


            // - Change Request -
            object request;
            try
            {
                TempData.TryGetValue("request", out request);
                request = JsonConvert.DeserializeObject<Request>((string)request);
                Request req = request as Request;
                req.technic = obj.technics;
                req.Place = obj.place;
                req.PlaceId = obj.place.Id;
                for (int i = 0; i < obj.technics.Count; i++)
                {
                    obj.technics[i].Request = req;
                }
                TempData["request"] = JsonConvert.SerializeObject(request, Formatting.None,
                      new JsonSerializerSettings()
                      {
                          ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                      });
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Section1");
            }

            if (res) return RedirectToAction("Supply", "ViewRequests");
            else return View(obj);

        }



    }
}
