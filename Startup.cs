using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UpdatingUserObjectDemo.Startup))]
namespace UpdatingUserObjectDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
