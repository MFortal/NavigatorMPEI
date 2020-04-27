using System.Web.Mvc;
using Services.Interfaces;

namespace Navigator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            var buildingService = DependencyResolver.Current.GetService(typeof(IBuildingService));
        }

    }
}