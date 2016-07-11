using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(interlibros.Startup))]
namespace interlibros
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          
        }
    }
}
