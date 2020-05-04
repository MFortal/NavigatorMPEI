using System;
using System.Web.Mvc;
using Abstractions.Interfaces;
using Abstractions.ViewModels;

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

        // Метод для проверки Ajax-запросов
        public ActionResult GetLevel(Guid id)
        {
            var level = new LevelVm
            {
                Id = id
            };
            return PartialView(level);
        }

        public ActionResult Get(string input1)
        {
            var model = new ItemVm
            {
                Description = input1
            };
            return PartialView(model);
        }

        public ActionResult SearchPath(Guid startId, Guid finishId)
        {
            var path = _mainMapService.GetPath(startId, finishId);
            return PartialView(path);
        }
    }
}