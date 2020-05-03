using System;
using System.Linq;
using System.Web.Mvc;
using Abstractions.Enums;
using Navigator.ViewModels;
using Services.Interfaces;

namespace Navigator.Controllers
{
    public class MainMapController : Controller
    {
        private readonly ILevelService _levelService;

        public MainMapController()
        {
            _levelService = DependencyResolver.Current.GetService<ILevelService>();
        }

        // GET: MainMap
        public ActionResult MainMap()
        {
            var level = _levelService.GetDefault();
            var border = level.Items
                .First(x => x.TypeItem.Type == ItemType.Border)
                .Nodes.Select(n => new PointVm(n.X, n.Y));

            var rooms = level.Items
                .Where(x => x.TypeItem.Type == ItemType.Room)
                .Select(x => new ItemVm()
                {
                    ItemId = x.Id,
                    Number = x.Number,
                    Description = x.Description,
                    Border = x.Nodes.Select(n => new PointVm(n.X, n.Y))
                });

            var stairs = level.Items
                .Where(x => x.TypeItem.Type == ItemType.Stairs)
                .Select(x => new ItemVm()
                {
                    ItemId = x.Id,
                    Border = x.Nodes.Select(n => new PointVm(n.X, n.Y))
                });

            var model = new MainMapVm
            {
                LevelId = level.Id,
                Border = border,
                Rooms = rooms,
                Stairs = stairs
            };
            
            return View(model);
        }

        // Метод для проверки Ajax-запросов
        public ActionResult GetLevel(Guid id)
        {
            var level = new LevelVm
            {
                id = id
            };
            return PartialView(level);
        }
    }
}