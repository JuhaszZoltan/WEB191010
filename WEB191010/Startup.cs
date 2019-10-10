using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEB191010.Startup))]
namespace WEB191010
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
