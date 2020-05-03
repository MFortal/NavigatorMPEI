using System;
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
        public ActionResult MainMap(Guid? levelId = null)
        {
            var model = _mainMapService.GetMainMap(levelId);            
            return View(model);
        }

        public ActionResult SearchPath(Guid startId, Guid finishId)
        {
            var path = _mainMapService.GetPath(startId, finishId).Path;
            return PartialView(path);
        }
    }
}