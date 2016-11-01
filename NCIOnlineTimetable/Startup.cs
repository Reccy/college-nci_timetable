using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCIOnlineTimetable.Startup))]
namespace NCIOnlineTimetable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
