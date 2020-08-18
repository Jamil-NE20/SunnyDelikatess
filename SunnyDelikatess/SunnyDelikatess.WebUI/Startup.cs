using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SunnyDelikatess.WebUI.Startup))]
namespace SunnyDelikatess.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
