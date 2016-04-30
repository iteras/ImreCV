using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImreCV.Startup))]
namespace ImreCV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
