using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DbEx3.Gateaway.Startup))]
namespace DbEx3.Gateaway
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
