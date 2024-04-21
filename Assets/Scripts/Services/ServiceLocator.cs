using System;
using System.Collections.Generic;
using Services;

namespace DefaultNamespace.EntryPoint
{
    public class ServiceLocator
    {
        private Dictionary<Type, IService> _services = new();
        
        public static ServiceLocator Instance;

        private ServiceLocator()
        {
        }

        public static void Init()
        {
            Instance = Instance != null ? Instance : new ServiceLocator();
        }

        public void RegisterService<T>(IService service) where T : IService =>
            _services.Add(typeof(T), service);


        public T GetService<T>() where T : IService => (T)_services[typeof(T)];
    }
}