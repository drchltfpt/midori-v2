using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MidoriV2.Startup))]
namespace MidoriV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
