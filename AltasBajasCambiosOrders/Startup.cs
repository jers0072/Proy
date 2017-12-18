using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AltasBajasCambiosOrders.Startup))]
namespace AltasBajasCambiosOrders
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
