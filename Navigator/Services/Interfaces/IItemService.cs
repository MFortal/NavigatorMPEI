using System;
using Services.Models;

namespace Services.Interfaces
{
    public interface IItemService
    {
        ItemSm Get(Guid id);
    }
}
