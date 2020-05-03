using System;
using System.Collections.Generic;
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
        private readonly IBuildingService _buildingService;

        public MainMapService(ILevelService levelService, IBuildingService buildingService)
        {
            _levelService = levelService;
            _buildingService = buildingService;
        }

        public MainMapVm GetMainMap(Guid? levelId = null)
        {
            var currentLevel = levelId.HasValue
                ? _levelService.Get(levelId.Value)
                : _levelService.GetDefault();

            var levels = _levelService.GetForBuilding(currentLevel.Building.Id)
                .Select(x => new LevelVm()
                {
                    Id = x.Id,
                    Number = x.Number
                })
                .OrderBy(x => x.Number);

            var border = currentLevel.Items
                .First(x => x.TypeItem.Type == ItemType.Border)
                .Nodes.Select(n => new PointVm(n.X, n.Y));

            var rooms = currentLevel.Items
                .Where(x => x.TypeItem.Type == ItemType.Room)
                .Select(x => new ItemVm()
                {
                    ItemId = x.Id,
                    Number = x.Number,
                    Description = x.Description,
                    Border = x.Nodes.Select(n => new PointVm(n.X, n.Y))
                });

            var stairs = currentLevel.Items
                .Where(x => x.TypeItem.Type == ItemType.Stairs)
                .Select(x => new ItemVm()
                {
                    ItemId = x.Id,
                    Border = x.Nodes.Select(n => new PointVm(n.X, n.Y))
                });

            var buildings = _buildingService.GetAll()
                .Select(x => new BuildingVm()
                {
                    Name = x.Name,
                    FirstLevelId = x.Levels.FirstOrDefault(l => l.Number == 1)?.Id 
                                   ?? throw new ApplicationException("Этаж не найден!")
                });

            var model = new MainMapVm
            {
                CurrentLevelId = currentLevel.Id,
                Border = border,
                Rooms = rooms,
                Stairs = stairs,
                Levels = levels,
                Buildings = buildings
            };
            return model;
        }

        public PathVm GetPath(Guid startItemId, Guid finishItemId)
        {
            // Todo : пока это заглушка
            return new PathVm() {Path = startItemId.ToString() + finishItemId};
        }
    }
}
