using EPA.Core.Entities;
using Repository;
using Repository.Providers.EntityFramework;
using System.Web.Http;
using Test.Services;
using Unity;
using Unity.WebApi;

namespace Test.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IDataContext, TestContext>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            
            container.RegisterType(typeof(Repository<>), typeof(IRepository<>));

            container.RegisterType<IOrderService, OrderService>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}