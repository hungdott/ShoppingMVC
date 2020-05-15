using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PMSShoppingApp.Startup))]
namespace PMSShoppingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ConfigAutofac(app);
        }
    }
}
