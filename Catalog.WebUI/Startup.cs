using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Catalog.WebUI.Startup))]
namespace Catalog.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
