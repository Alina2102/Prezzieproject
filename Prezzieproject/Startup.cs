using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prezzieproject.Startup))]
namespace Prezzieproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
