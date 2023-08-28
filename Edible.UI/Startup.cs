using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Edible.UI.Startup))]
namespace Edible.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
