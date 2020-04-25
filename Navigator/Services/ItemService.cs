using System;
using DataLayer;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class ItemService : IItemService
    {
        private readonly IBuildingService _buildingService;
        private readonly ILevelService _levelService;
        private readonly ITypeItemService _typeItemService;
        private readonly INodeService _nodeService;

        public ItemService(IBuildingService buildingService, ILevelService levelService, ITypeItemService typeItemService, INodeService nodeService)
        {
            _buildingService = buildingService;
            _levelService = levelService;
            _typeItemService = typeItemService;
            _nodeService = nodeService;
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
                    Level = _levelService.Get(item.LevelId),
                    TypeItem = _typeItemService.Get(item.TypeItemId),
                    Nodes = _nodeService.GetLine(item.NodeId),
                };
            }
        }
    }
}
