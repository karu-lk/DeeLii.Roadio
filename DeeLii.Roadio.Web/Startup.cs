using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeeLii.Roadio.Web.Startup))]
namespace DeeLii.Roadio.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
