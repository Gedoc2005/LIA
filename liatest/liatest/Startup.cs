using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(liatest.Startup))]
namespace liatest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
