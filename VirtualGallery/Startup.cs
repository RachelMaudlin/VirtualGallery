using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VirtualGallery.Startup))]
namespace VirtualGallery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
