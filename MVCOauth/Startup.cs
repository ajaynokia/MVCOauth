using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCOauth.Startup))]
namespace MVCOauth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
