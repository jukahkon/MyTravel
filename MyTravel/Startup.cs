using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTravel.Startup))]
namespace MyTravel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
