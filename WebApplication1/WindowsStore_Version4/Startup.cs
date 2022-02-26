using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WindowsStore_Version4.Startup))]
namespace WindowsStore_Version4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
