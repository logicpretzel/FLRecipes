using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FLRecipes.Startup))]
namespace FLRecipes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
