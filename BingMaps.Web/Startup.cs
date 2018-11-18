using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BingMaps.Web.Startup))]
namespace BingMaps.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
