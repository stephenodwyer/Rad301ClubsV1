using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rad301ClubsV1.Startup))]
namespace Rad301ClubsV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
