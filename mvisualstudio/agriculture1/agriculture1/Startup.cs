using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(agriculture1.Startup))]
namespace agriculture1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
