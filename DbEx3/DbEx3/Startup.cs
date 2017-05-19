using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DbEx3.Startup))]
namespace DbEx3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
