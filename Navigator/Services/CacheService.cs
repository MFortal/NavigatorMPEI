using System;
using System.Runtime.Caching;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class CacheService : ICacheService
    {
        private static readonly MemoryCache Cache = MemoryCache.Default;

        public T Get<T>(Guid id, Func<Guid, T> firstGetFunc) where T : BaseSmModel
        {
            var key = nameof(T) + id;
            var result = (T)Cache.Get(key);
            return result ?? firstGetFunc.Invoke(id);
        }
    }
}
