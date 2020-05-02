using System;
using System.Linq;
using DataLayer;
using DataLayer.Models.DataModels;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class LevelService : ILevelService
    {
        private readonly IItemService _itemService;
        private readonly IBuildingService _buildingService;

        public LevelService(IBuildingService buildingService, ITypeItemService typeItemService, INodeService nodeService)
        {
            _itemService = new ItemService(typeItemService, nodeService, this);
            _buildingService = buildingService;
        }

        public LevelSm Get(Guid id)
        {
            using (var db = new NavigatorContext())
            {
                var level = db.Levels.Find(id);
                if (level == null)
                {
                    return null;
                }

                var levelSm = ToSmModel(level);
                var items = db.Items.Where(x => x.LevelId == level.Id);
                var itemsSm = items
                    .AsEnumerable()
                    .Select(x =>_itemService.ToSmModel(x, levelSm))
                    .ToList();

                
                levelSm.Items = itemsSm;
                return levelSm;
            }
        }

        public LevelSm GetDefault()
        {
            using (var db = new NavigatorContext())
            {
                // Todo: выбрать вначале дефолтное здание
                var defaultLevel = db.Levels.FirstOrDefault(x => x.Number == 1);

                return defaultLevel != null ? Get(defaultLevel.Id) : null;
            }
        }

        private LevelSm ToSmModel(Level level)
        {
            return new LevelSm()
            {
                Id = level.Id,
                Number = level.Number,
                Building = _buildingService.Get(level.BuildingId)
            };
        }
    }
}
