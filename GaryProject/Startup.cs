using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GaryProject.Startup))]
namespace GaryProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
