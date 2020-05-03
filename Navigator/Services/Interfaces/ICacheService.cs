using System;
using Services.Models;

namespace Services.Interfaces
{
    public interface ICacheService
    {
        T Get<T>(Guid id, Func<Guid, T> firstGetFunc) where T : BaseSmModel;
    }
}
