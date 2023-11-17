using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stud_rec.Startup))]
namespace Stud_rec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
