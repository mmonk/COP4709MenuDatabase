using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COP4709MenuDatabase.Startup))]
namespace COP4709MenuDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
