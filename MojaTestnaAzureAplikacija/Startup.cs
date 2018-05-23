using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MojaTestnaAzureAplikacija.Startup))]
namespace MojaTestnaAzureAplikacija
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
