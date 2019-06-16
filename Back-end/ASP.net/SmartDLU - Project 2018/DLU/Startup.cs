using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DLU.Startup))]
namespace DLU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
