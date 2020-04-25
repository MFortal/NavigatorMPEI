using System;
using Services.Models;

namespace Services.Interfaces
{
    public interface ILevelService
    {
        LevelSm Get(Guid id);
    }
}
