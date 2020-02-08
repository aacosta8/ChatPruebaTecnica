using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ChatPruebaTecnica.Startup))]

namespace ChatPruebaTecnica
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
