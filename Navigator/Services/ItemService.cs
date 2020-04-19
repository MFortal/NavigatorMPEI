using System;
using DataLayer;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class ItemService : IItemService
    {
        private readonly IBuildingService _buildingService;

        public ItemService(IBuildingService buildingService)
        {
            _buildingService = buildingService;
        }

        public ItemSm Get(Guid id)
        {
            using (var db = new NavigatorContext())
            {
                var item = db.Items.Find(id);
                if (item == null)
                {
                    return null;
                }

                return new ItemSm()
                {
                    Id = item.Id,
                    Description = item.Description,
                    Number = item.Number,
                    Repair = item.Repair,
                    Building = _buildingService.Get(item.BuildingId),
                    // Level = _levelService.Get()
                    // и т д

                };
            }
        }
    }
}
