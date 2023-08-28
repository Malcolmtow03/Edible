using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Edible.Startup))]
namespace Edible
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
