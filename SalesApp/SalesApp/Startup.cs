using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesApp.Startup))]
namespace SalesApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
