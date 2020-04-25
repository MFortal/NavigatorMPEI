using System;
using DataLayer;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class LevelService : ILevelService
    {
        public LevelSm Get(Guid id)
        {
            using (var db = new NavigatorContext())
            {
                var level = db.Levels.Find(id);
                if (level == null)
                {
                    return null;
                }

                return new LevelSm()
                {
                    Id = level.Id,
                    Name = level.Name
                };
            }
        }
    }
}
