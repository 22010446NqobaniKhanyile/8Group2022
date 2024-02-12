using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataVic.Startup))]
namespace DataVic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
