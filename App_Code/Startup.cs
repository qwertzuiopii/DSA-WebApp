using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projects.Startup))]
namespace Projects
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
