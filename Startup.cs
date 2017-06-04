using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yakuza.Startup))]
namespace Yakuza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
