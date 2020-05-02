using System;
using System.Collections.Generic;
using DataLayer.Models.DataModels;
using Services.Models;

namespace Services.Interfaces
{
    public interface ILevelService
    {
        LevelSm Get(Guid id);

        LevelSm GetDefault();

        IEnumerable<LevelSm> GetForBuilding(Guid buildingId);

        LevelSm ToSmModel(Level level, BuildingSm buildingSm = null);
    }
}
