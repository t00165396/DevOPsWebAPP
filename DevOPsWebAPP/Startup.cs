using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOPsWebAPP.Startup))]
namespace DevOPsWebAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //test...
        }
    }
}
