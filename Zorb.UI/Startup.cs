using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zorb.UI.Startup))]
namespace Zorb.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
