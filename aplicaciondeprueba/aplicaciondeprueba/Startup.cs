using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aplicaciondeprueba.Startup))]
namespace aplicaciondeprueba
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
