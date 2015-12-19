using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdvertApp.Startup))]
namespace AdvertApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
