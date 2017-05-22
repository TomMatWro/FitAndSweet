using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitAndSweet.Startup))]
namespace FitAndSweet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
