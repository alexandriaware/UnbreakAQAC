using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UNBREAKAQAC2.Startup))]
namespace UNBREAKAQAC2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
