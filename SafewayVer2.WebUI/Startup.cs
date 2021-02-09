using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SafewayVer2.WebUI.Startup))]
namespace SafewayVer2.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
