using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnboardingRecycle.Startup))]
namespace OnboardingRecycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
