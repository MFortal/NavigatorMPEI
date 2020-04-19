using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Services;
using Services.Interfaces;

namespace Navigator
{
    public class NavigatorDependencyResolver : IDependencyResolver
    {
        private readonly IBuildingService _buildingService;
        private readonly IItemService _itemService;

        public NavigatorDependencyResolver()
        {
            _buildingService = new BuildingService();
            _itemService = new ItemService(_buildingService);
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}