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

        public ItemService(ITypeItemService typeItemService, INodeService nodeService)
        {            
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

                var itemSm = ToSmModel(item);
                itemSm.Level.Items = db.Items
                    .Where(x => x.LevelId == item.LevelId)
                    .AsEnumerable()
                    .Select(ToSmModel)
                    .ToList();
                return itemSm;
            }
        }

        public ItemSm ToSmModel(Item item)
        {
            return new ItemSm()
            {
                Id = item.Id,
                Description = item.Description,
                Number = item.Number,
                Repair = item.Repair,
                Level = new LevelSm()
                {
                    Id = item.LevelId,
                    Number = item.Level.Number
                },
                TypeItem = _typeItemService.Get(item.TypeItemId),
                Nodes = _nodeService.GetLine(item.NodeId),
            };
        }
    }
}
