using Microsoft.AspNetCore.Mvc;
using TeamProject.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.ViewModels;

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

        public ViewResult Index()
        {
            Section2ViewModel obj = new Section2ViewModel();
            obj.AllPlaces = _allPlaces.AllPlaces;
            obj.AllTypeTechnics = _allTypeTechnics.AllType;
            obj.AllExecutors = _allExecutors.AllExecutors;
            return View(obj);
        }
    }
}
