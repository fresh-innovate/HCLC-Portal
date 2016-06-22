using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hackney.Startup))]
namespace Hackney
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
