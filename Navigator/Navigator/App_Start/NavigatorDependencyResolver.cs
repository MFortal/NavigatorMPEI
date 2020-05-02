using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Abstractions.Interfaces;
using Services;
using Services.Interfaces;
using Services.OuterServices;

namespace Navigator
{
    public class NavigatorDependencyResolver : IDependencyResolver
    {
        private readonly Dictionary<Type, object> _serviceMap = new Dictionary<Type, object>();
        private readonly IDependencyResolver _defaultResolver;

        public NavigatorDependencyResolver(IDependencyResolver defaultResolver)
        {
            _defaultResolver = defaultResolver;
            
            ITypeItemService typeItemService = new TypeItemService();
            INodeService nodeService = new NodeService();
            IBuildingService buildingService = new BuildingService(typeItemService, nodeService);
            ILevelService levelService = new LevelService(buildingService, typeItemService, nodeService);
            IItemService itemService = new ItemService(typeItemService, nodeService, levelService);

            _serviceMap.Add(typeof(IBuildingService), buildingService);
            _serviceMap.Add(typeof(ITypeItemService), typeItemService);
            _serviceMap.Add(typeof(INodeService), nodeService);
            _serviceMap.Add(typeof(ILevelService), levelService);
            _serviceMap.Add(typeof(IItemService), itemService);

            #region OuterServices

            IMainMapService mainMapService = new MainMapService(levelService, buildingService);

            _serviceMap.Add(typeof(IMainMapService), mainMapService);

            #endregion
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
                ? new[] { service }
                : _defaultResolver.GetServices(serviceType);
        }
    }
}