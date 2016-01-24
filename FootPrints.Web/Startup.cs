using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootPrints.Web.Startup))]
namespace FootPrints.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
