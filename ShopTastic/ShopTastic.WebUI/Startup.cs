using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopTastic.WebUI.Startup))]
namespace ShopTastic.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
