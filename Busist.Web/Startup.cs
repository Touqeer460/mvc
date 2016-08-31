using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Busist.Web.Startup))]
namespace Busist.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
