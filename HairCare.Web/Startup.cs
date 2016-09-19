using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HairCare.Web.Startup))]
namespace HairCare.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
