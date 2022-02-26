using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SqlInjectionLogin.Startup))]
namespace SqlInjectionLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
