using System;
using DataLayer.Models.DataModels;
using Services.Models;

namespace Services.Interfaces
{
    public interface IItemService
    {
        ItemSm Get(Guid id);

        ItemSm ToSmModel(Item item, LevelSm levelSm = null);
    }
}
