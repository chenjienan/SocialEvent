using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialEvent.Startup))]
namespace SocialEvent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
