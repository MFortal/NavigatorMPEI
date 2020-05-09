using System;
using System.Linq;
using Abstractions.Enums;
using Abstractions.Interfaces;
using Abstractions.ViewModels;
using Services.DiscreteMap;
using Services.Interfaces;

namespace Services.OuterServices
{
    public class MainMapService : IMainMapService
    {
        private readonly ILevelService _levelService;
        private readonly IBuildingService _buildingService;
        private readonly IItemService _itemService;
        private readonly IDiscreteMapService _discreteMapService;

        public MainMapService(ILevelService levelService, IBuildingService buildingService, IItemService itemService, IDiscreteMapService discreteMapService)
        {
            _levelService = levelService;
            _buildingService = buildingService;
            _itemService = itemService;
            _discreteMapService = discreteMapService;
        }

        public MainMapVm GetMainMap(Guid? levelId = null)
        {
            var currentLevel = levelId.HasValue
                ? _levelService.Get(levelId.Value)
                : _levelService.GetDefault();

            var levels = _levelService.Get(currentLevel.Building)
                .Select(x => new LevelVm()
                {
                    Id = x.Id,
                    Number = x.Number
                })
                .OrderBy(x => x.Number);

            var border = _itemService.Get(currentLevel, ItemType.Border)
                .First(x => x.TypeItem.Type == ItemType.Border)
                .Nodes.Select(n => new PointVm(n.X, n.Y));

            var rooms = _itemService.Get(currentLevel, ItemType.Room)
                .Select(x => new ItemVm()
                {
                    ItemId = x.Id,
                    Number = x.Number,
                    Description = x.Description,
                    Border = x.Nodes.Select(n => new PointVm(n.X, n.Y))
                });

            var stairs = _itemService.Get(currentLevel, ItemType.Stairs)
                .Select(x => new ItemVm()
                {
                    ItemId = x.Id,
                    Border = x.Nodes.Select(n => new PointVm(n.X, n.Y))
                });

            var buildings = _buildingService.GetAll()
                .Select(x => new BuildingVm()
                {
                    Name = x.Name,
                    FirstLevelId = _levelService.Get(x)
                                       .FirstOrDefault(l => l.Number == 1)?.Id
                                   ?? throw new ApplicationException("Этаж не найден!")
                });

            var items = _itemService.GetAll()
                .Select(x => new ItemVm()
                {
                    ItemId = x.Id,
                    Number = x.Number
                })
                .OrderBy(x => x.Number);

            var model = new MainMapVm
            {
                CurrentLevelId = currentLevel.Id,
                Border = border,
                Rooms = rooms,
                Stairs = stairs,
                Levels = levels,
                Buildings = buildings,
                Items = items
            };
            return model;
        }

        public PathVm GetPath(Guid startItemId, Guid finishItemId)
        {
            var startItem = _itemService.Get(startItemId);
            var finishItem = _itemService.Get(finishItemId);

            var startLevel = startItem.Level;
            var finishLevel = finishItem.Level;

            if (startLevel.Building != finishLevel.Building)
            {
                throw new ApplicationException();
            }
            var building = startLevel.Building;

            var minLevelNumber = new[] { startLevel, finishLevel }.Select(x => x.Number).Min();
            var maxLevelNumber = new[] { startLevel, finishLevel }.Select(x => x.Number).Max();

            var filteredLevels = _levelService.Get(building)
                .Where(x => x.Number >= minLevelNumber && x.Number <= maxLevelNumber)
                .OrderBy(x => x.Number);

            var items = filteredLevels.SelectMany(x => _itemService.Get(x)).ToList();
            var minMax = _discreteMapService.FindMinMaxCoordinate(items);
            var field = new DiscreteMapField(minMax.Item1, minMax.Item2);
            _discreteMapService.CreateWalls(field, items);

            field.PrintToFile();
            // Todo : пока это заглушка
            return new PathVm() { Path = startItemId.ToString() + finishItemId };
        }

        public Guid GetItemId(string number)
        {
            return _itemService.Get(number);
        }
    }
}
