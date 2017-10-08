using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(jogplannerService.Startup))]

namespace jogplannerService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}