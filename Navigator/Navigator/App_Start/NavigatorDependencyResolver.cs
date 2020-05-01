using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Services;
using Services.Interfaces;

namespace Navigator
{
    public class NavigatorDependencyResolver : IDependencyResolver
    {
        private readonly Dictionary<Type, object> _serviceMap = new Dictionary<Type, object>();
        private readonly IDependencyResolver _defaultResolver;

        public NavigatorDependencyResolver(IDependencyResolver defaultResolver)
        {
            _defaultResolver = defaultResolver;

            IBuildingService buildingService = new BuildingService();
            ITypeItemService typeItemService = new TypeItemService();
            INodeService nodeService = new NodeService();
            ILevelService levelService = new LevelService(buildingService, typeItemService, nodeService);            
            IItemService itemService = new ItemService(typeItemService, nodeService, levelService);

            _serviceMap.Add(typeof(IBuildingService), buildingService);
            _serviceMap.Add(typeof(ITypeItemService), typeItemService);
            _serviceMap.Add(typeof(INodeService), nodeService);
            _serviceMap.Add(typeof(ILevelService), levelService);
            _serviceMap.Add(typeof(IItemService), itemService);            
        }

        public object GetService(Type serviceType)
        {
            return _serviceMap.TryGetValue(serviceType, out var service) 
                ? service 
                : _defaultResolver.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _serviceMap.TryGetValue(serviceType, out var service)
                ? new []{service}
                : _defaultResolver.GetServices(serviceType);
        }
    }
}