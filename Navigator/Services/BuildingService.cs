﻿using System;
using DataLayer;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class BuildingService : IBuildingService
    {
        public BuildingSm Get(Guid id)
        {
            using (var db = new NavigatorContext())
            {
                var building = db.Buildings.Find(id);
                if (building == null)
                {
                    return null;
                }

                return new BuildingSm()
                {
                    Id = building.Id,
                    Name = building.Name
                };
            }
        }
    }
}
