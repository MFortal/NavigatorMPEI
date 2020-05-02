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
    }
}