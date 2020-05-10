using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PMSShoppingApp.Startup))]
namespace PMSShoppingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
