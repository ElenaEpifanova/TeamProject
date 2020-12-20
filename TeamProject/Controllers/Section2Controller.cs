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

        public ActionResult Index(bool supply=false)
        {
            Section2ViewModel obj = new Section2ViewModel();

            //
            obj.technics[0].TypeTechnic = _allTypeTechnics.AllType.First();
            obj.technics[0].TypeTechnicId = obj.technics[0].TypeTechnic.Id;
            obj.technics[0].Executor = _allExecutors.AllExecutors.First();

            // - get Request -
            object request;
            try
            {
                TempData.TryGetValue("request", out request);
                request = JsonConvert.DeserializeObject<Request>((string)request);
                Request req = request as Request;
                TempData.Remove("request");
                DateTime b = req.begin.Date, end = req.end.Date;
                obj.timeq = ((Convert.ToInt32(end.Subtract(b).Days + 1) * 12) - (req.begin.Hour - 8) - (20 - req.end.Hour)) * 2;
                if (supply)
                {
                    obj.place = req.Place;
                    obj.technics = req.technic;
                    obj.quantity = obj.technics.Count;
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

            Initial(obj);

           

            return View(obj);
        }

        private void Initial(Section2ViewModel obj)
        {
            obj.AllPlaces = _allPlaces.AllPlaces;
            obj.AllTypeTechnics = _allTypeTechnics.AllType.OrderBy(t => t.Id);
            obj.AllExecutors = _allExecutors.AllExecutors;

            // - Quntity -
            if (obj.Quntity.Count == 0)
                for (int i = 0; i < _allTypeTechnics.AllType.Count(); i++)
                    obj.Quntity.Add(obj.AllTypeTechnics.ElementAt(i).quantity);
        }

        [HttpPost]
        public IActionResult Index(Section2ViewModel obj, bool supply = false, bool section1=false)
        {
            Initial(obj);

            if (!supply)
                Add_Del_block(obj);

            FillPlace(obj);
            FillTypeTechnic(obj);
            FillExecutor(obj);

            // - Change Request -
            object request;
            try
            {
                TempData.TryGetValue("request", out request);
                request = JsonConvert.DeserializeObject<Request>((string)request);
                Request req = request as Request;
                TempData.Remove("request");
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

            if (supply) return RedirectToAction("Supply", "Home");
            else if(section1) return RedirectToAction("Index", "Section1", new {supply=true });
            else return View(obj);

        }

        private void FillExecutor(Section2ViewModel obj)
        {
            // - Executor -
            for (int i = 0; i < obj.technics.Count; i++)
            {
                Executor temp = _allExecutors.AllExecutors.First(C => C.Id == obj.technics[i].Executor.Id);
                obj.technics[i].Executor = temp;
                obj.technics[i].ExecutorId = temp.Id;
            }
        }

        private void FillTypeTechnic(Section2ViewModel obj)
        {
            // - TypeTechnic -
            for (int i = 0; i < obj.technics.Count; i++)
            {
                TypeTechnic tmp = _allTypeTechnics.AllType.First(C => C.Id == obj.technics[i].TypeTechnic.Id);
                obj.technics[i].TypeTechnic = tmp;
                obj.technics[i].TypeTechnicId = tmp.Id;

            }
        }

        private void FillPlace(Section2ViewModel obj)
        {
            // - Place -
            Place pl = _allPlaces.AllPlaces.First(p => p.Id == obj.place.Id);
            obj.place = pl;
        }

        private void Add_Del_block(Section2ViewModel obj)
        {
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
    }
}
