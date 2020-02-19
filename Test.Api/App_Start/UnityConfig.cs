using EPA.Core.Entities;
using Repository;
using Repository.Providers.EntityFramework;
using System;
using System.Web.Http;
using Test.Api.Controllers;
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
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static IUnityContainer GetConfiguredContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IDataContext, TestContext>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            container.RegisterType<IOrderService, OrderService>();

            // Register controller
            container.RegisterType<OrderController>();

            // Register interface
            container.RegisterType<IRepository<TestOrder>, Repository<TestOrder>>();

            //This is done in Startup instead.
            //GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            return container;
        }
    }
}