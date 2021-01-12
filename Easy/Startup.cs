using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Easy.Startup))]
namespace Easy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
