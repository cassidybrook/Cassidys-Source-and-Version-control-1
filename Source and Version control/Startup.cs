using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Source_and_Version_control.Startup))]
namespace Source_and_Version_control
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
