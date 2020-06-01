using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeTimeSheet.Startup))]
namespace EmployeeTimeSheet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
