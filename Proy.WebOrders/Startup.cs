using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proy.WebOrders.Startup))]
namespace Proy.WebOrders
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
