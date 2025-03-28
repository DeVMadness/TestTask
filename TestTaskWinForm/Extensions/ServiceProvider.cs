using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskWinForm.Extensions
{
    public class ServiceProvider
    {
        private static readonly Lazy<ServiceProvider> _instance = new(() => new ServiceProvider());
        private readonly Dictionary<Type, Func<object>> _services = new();

        public static ServiceProvider Instance => _instance.Value; 

        private ServiceProvider() { }

        public void Register<TAbstraction>(Func<TAbstraction> factory)
            where TAbstraction : class
        {
            _services[typeof(TAbstraction)] = factory;
        }

        public TAbstraction GetService<TAbstraction>()
            where TAbstraction : class
        {
            if (_services.TryGetValue(typeof(TAbstraction), out var factory))
            {
                return (TAbstraction)factory();
            }
            throw new Exception($"Service {typeof(TAbstraction)} not registered.");
        }
    }
}
