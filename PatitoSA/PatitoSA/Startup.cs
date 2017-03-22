using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PatitoSA.Startup))]
namespace PatitoSA
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
