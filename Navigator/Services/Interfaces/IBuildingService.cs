using System;
using Services.Models;

namespace Services.Interfaces
{
    public interface IBuildingService
    {
        BuildingSm Get(Guid id);
    }
}
