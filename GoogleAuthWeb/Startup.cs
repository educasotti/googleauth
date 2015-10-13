using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleAuthWeb.Startup))]
namespace GoogleAuthWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
