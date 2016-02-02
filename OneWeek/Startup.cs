using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneWeek.Startup))]
namespace OneWeek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
