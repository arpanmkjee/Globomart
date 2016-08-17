using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GloboMart.Client.MVC.Startup))]
namespace GloboMart.Client.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
