using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cours.MVC.Bootstrap.Startup))]
namespace Cours.MVC.Bootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
