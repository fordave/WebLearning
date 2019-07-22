using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormFirst.Startup))]
namespace WebFormFirst
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
