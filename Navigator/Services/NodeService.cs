using System.Collections.Generic;
using Services.Enums;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class NodeService : INodeService
    {
        public IList<NodeSm> Get(ItemSm item)
        {
            var firstNode = item.FirstNode;
            var result = new List<NodeSm> {firstNode};

            var type = ItemType.Room;
            if (type == ItemType.Room)
            {

            }

        }
    }
}
