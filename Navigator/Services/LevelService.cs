using System;
using DataLayer;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class LevelService : ILevelService
    {
        private readonly IBuildingService _buildingService;

        public LevelService(IBuildingService buildingService)
        {
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

                return new LevelSm()
                {
                    Id = level.Id,
                    Number = level.Number,
                    Building = _buildingService.Get(level.BuildingId)
                };
            }
        }
    }
}
