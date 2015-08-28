using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KidsChurch.Startup))]
namespace KidsChurch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
