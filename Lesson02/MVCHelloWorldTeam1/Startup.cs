using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHelloWorldTeam1.Startup))]
namespace MVCHelloWorldTeam1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
