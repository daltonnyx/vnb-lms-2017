using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vnb.lms._2017.Startup))]
namespace vnb.lms._2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
