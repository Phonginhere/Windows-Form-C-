using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Db_first.Startup))]
namespace Db_first
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
