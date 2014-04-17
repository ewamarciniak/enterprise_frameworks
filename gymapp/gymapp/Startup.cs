using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gymapp.Startup))]
namespace gymapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
