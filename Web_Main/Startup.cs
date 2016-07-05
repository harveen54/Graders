using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Main.Startup))]
namespace Web_Main
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
