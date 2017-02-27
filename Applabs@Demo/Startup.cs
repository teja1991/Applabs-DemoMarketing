using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Applabs_Demo.Startup))]
namespace Applabs_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
