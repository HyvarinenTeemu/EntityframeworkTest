using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityframeworkTest.Startup))]
namespace EntityframeworkTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
