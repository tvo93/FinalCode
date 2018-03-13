using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(VolunteerSystem.Startup))]
namespace VolunteerSystem
{
    public partial class Startup

    {
        public void ConfigurationSignalR(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}