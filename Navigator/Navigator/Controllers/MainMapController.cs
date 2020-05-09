using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Abstractions.Interfaces;

namespace Navigator.Controllers
{
    public class MainMapController : Controller
    {
        private readonly IMainMapService _mainMapService;

        public MainMapController()
        {
            _mainMapService = DependencyResolver.Current.GetService<IMainMapService>();
        }

        // GET: MainMap
        public ActionResult MainMap()
        {
            var model = _mainMapService.GetMainMap();
            return View(model);
        }

        public ActionResult GetMap(Guid? levelId = null)
        {
            var model = _mainMapService.GetMainMap(levelId);
            return View(model);
        }

        // Метод для проверки Ajax-запросов
        
        public ActionResult Get(List<string> items)
        {
            var startId = _mainMapService.GetItemId(items[0]);
            var finishId = _mainMapService.GetItemId(items[1]);

            return PartialView();
        }

        public ActionResult SearchPath(string fromItem, string toItem)
        {
            // Todo: подругому получить 
            var startId = _mainMapService.GetItemId(fromItem);
            var finishId = _mainMapService.GetItemId(toItem);
            var path = _mainMapService.GetPath(startId, finishId);
            return PartialView(path);
        }
    }
}