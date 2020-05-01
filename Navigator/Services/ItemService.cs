using System;
using System.Linq;
using DataLayer;
using DataLayer.Models.DataModels;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class ItemService : IItemService
    {
        private readonly ITypeItemService _typeItemService;
        private readonly INodeService _nodeService;
        private readonly ILevelService _levelService;

        public ItemService(ITypeItemService typeItemService, INodeService nodeService, ILevelService levelService)
        {            
            _typeItemService = typeItemService;
            _nodeService = nodeService;
            _levelService = levelService;
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

                return ToSmModel(item);
            }
        }

        public ItemSm ToSmModel(Item item, LevelSm levelSm = null)
        {
            return new ItemSm()
            {
                Id = item.Id,
                Description = item.Description,
                Number = item.Number,
                Repair = item.Repair,
                Level = levelSm ?? _levelService.Get(item.LevelId),
                TypeItem = _typeItemService.Get(item.TypeItemId),
                Nodes = _nodeService.GetLine(item.NodeId),
            };
        }
    }
}
