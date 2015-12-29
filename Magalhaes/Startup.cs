using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Magalhaes.Startup))]
namespace Magalhaes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
