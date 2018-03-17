using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testJenkins.Startup))]
namespace testJenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
