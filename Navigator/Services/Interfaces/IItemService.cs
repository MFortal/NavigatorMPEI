using System;
using System.Collections.Generic;
using Abstractions.Enums;
using Services.Models;

namespace Services.Interfaces
{
    public interface IItemService
    {
        ItemSm Get(Guid id);

        IList<ItemSm> Get(LevelSm level, ItemType? type = null);

        IList<ItemSm> GetAll();

        Guid Get(string number);
    }
}
