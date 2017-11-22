using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DENOF.Startup))]
namespace DENOF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
