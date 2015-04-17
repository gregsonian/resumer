using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(net.mattersofgrey.resumer.Startup))]
namespace net.mattersofgrey.resumer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
