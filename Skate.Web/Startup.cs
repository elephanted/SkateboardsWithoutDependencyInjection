using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Skate.Web.Startup))]
namespace Skate.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
