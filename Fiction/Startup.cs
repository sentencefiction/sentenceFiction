using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fiction.Startup))]
namespace Fiction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
