using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(skAmazon2.Startup))]
namespace skAmazon2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
