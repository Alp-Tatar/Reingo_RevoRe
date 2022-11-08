using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reingo_Revo.Startup))]
namespace Reingo_Revo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
