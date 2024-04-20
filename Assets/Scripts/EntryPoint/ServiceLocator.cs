using System;
using System.Collections.Generic;
using Services;

namespace DefaultNamespace.EntryPoint
{
    public class ServiceLocator
    {
        private Dictionary<Type, IService> _services;
        public static ServiceLocator Instance;

        private ServiceLocator()
        {
        }

        public void Init()
        {
            if (Instance == null)
                Instance = new ServiceLocator();
        }

        public void RegisterService<TService>(TService service) where TService : IService =>
            _services.Add(typeof(TService), service);


        public TService GetService<TService>() where TService : IService => (TService)_services[typeof(TService)];
        
    }
}