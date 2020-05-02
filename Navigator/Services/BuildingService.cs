using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class BuildingService : IBuildingService
    {
        private readonly ILevelService _levelService;

        public BuildingService(ITypeItemService typeItemService, INodeService nodeService)
        {
            _levelService = new LevelService(this, typeItemService, nodeService);
        }

        public BuildingSm Get(Guid id)
        {
            using (var db = new NavigatorContext())
            {
                var building = db.Buildings.Find(id);
                if (building == null)
                {
                    return null;
                }

                var buildingSm = new BuildingSm()
                {
                    Id = building.Id,
                    Name = building.Name
                };

                var levels = db.Levels.Where(x => x.BuildingId == building.Id);
                var levelsSm = levels
                    .AsEnumerable()
                    .Select(x => _levelService.ToSmModel(x, buildingSm))
                    .ToList();

                buildingSm.Levels = levelsSm;

                return buildingSm;
            }
        }

        public IEnumerable<BuildingSm> GetAll()
        {
            using (var db = new NavigatorContext())
            {
                if (db.Buildings.Any())
                {
                    return db.Buildings
                        .AsEnumerable()
                        .Select(x => Get(x.Id))
                        .ToList();
                }

                return null;
            }
        }
    }
}
