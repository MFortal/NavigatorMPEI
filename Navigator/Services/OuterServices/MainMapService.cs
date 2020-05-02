using System;
using System.Linq;
using Abstractions.Enums;
using Abstractions.Interfaces;
using Abstractions.ViewModels;
using Services.Interfaces;

namespace Services.OuterServices
{
    public class MainMapService : IMainMapService
    {
        private readonly ILevelService _levelService;

        public MainMapService(ILevelService levelService)
        {
            _levelService = levelService;
        }

        public MainMapVm GetMainMap(Guid? levelId = null)
        {
            var level = levelId.HasValue 
                ? _levelService.Get(levelId.Value) 
                : _levelService.GetDefault();

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
                CurrentLevelId = level.Id,
                Border = border,
                Rooms = rooms,
                Stairs = stairs
            };
            return model;
        }
    }
}
