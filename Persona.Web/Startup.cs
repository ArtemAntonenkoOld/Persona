using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Persona.Web.Startup))]
namespace Persona.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
