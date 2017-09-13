using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DisplayDeviceMVC.Startup))]
namespace DisplayDeviceMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
