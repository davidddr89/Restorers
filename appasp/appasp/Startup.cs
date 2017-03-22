using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(appasp.Startup))]
namespace appasp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
