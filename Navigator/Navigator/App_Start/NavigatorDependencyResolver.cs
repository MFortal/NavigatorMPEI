using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Services;
using Services.Interfaces;

namespace Navigator
{
    public class NavigatorDependencyResolver : IDependencyResolver
    {
        private readonly IBuildingService _buildingService;
        private readonly IItemService _itemService;
        private readonly ILevelService _levelService;
        private readonly ITypeItemService _typeItemService;
        private readonly INodeService _nodeService;


        public NavigatorDependencyResolver()
        {
            _buildingService = new BuildingService();
            _levelService = new LevelService();
            _typeItemService = new TypeItemService();
            _nodeService = new NodeService();
            _itemService = new ItemService(_buildingService, _levelService, _typeItemService, _nodeService);
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