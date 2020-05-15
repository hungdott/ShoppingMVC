using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Autofac;
using System.Reflection;
using PMSShopping.Data.Infrastructure;
using PMSShopping.Data.Reponsitories;
using PMSShopping.Services;
using System.Web.Mvc;
using System.Web.Http;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using PMSShopping.Data;
using Microsoft.AspNet.Identity;
using PMSShoppingApp.Models;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataProtection;
using System.Web;

[assembly: OwinStartup(typeof(PMSShoppingApp.Startup))]

namespace PMSShoppingApp
{
    public partial class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
            
        //    ConfigureAuth(app);
        //    //ConfigureAuth(app);
        //}
        private void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //Register web api controller
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<PMSShoppingDBContext>().AsSelf().InstancePerRequest();

            //Asp.net Identity
            //builder.RegisterType<ApplicationUserStore>().As<IUserStore<ApplicationUser>>().InstancePerRequest();
            //builder.RegisterType<ApplicationUserManager>().AsSelf().InstancePerRequest();
            //builder.RegisterType<ApplicationSignInManager>().AsSelf().InstancePerRequest();
            //builder.Register(c => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            //builder.Register(c => app.GetDataProtectionProvider()).InstancePerRequest();

            //repository
            builder.RegisterAssemblyTypes(typeof(SlideRepository).Assembly)
              .Where(n => n.Name.EndsWith("Repository"))
              .AsImplementedInterfaces().InstancePerRequest();

            //service
            builder.RegisterAssemblyTypes(typeof(SlideService).Assembly)
              .Where(n => n.Name.EndsWith("Service"))
              .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        }
    }
}