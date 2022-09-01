using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5032_WEEK5_MyIdentity.Startup))]
namespace FIT5032_WEEK5_MyIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
