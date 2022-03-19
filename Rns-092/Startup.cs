using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rns_092.Startup))]
namespace Rns_092
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
