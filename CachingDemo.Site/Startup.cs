using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CachingDemo.Site.Startup))]
namespace CachingDemo.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
