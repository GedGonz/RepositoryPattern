using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepositoryPatterns.Startup))]
namespace RepositoryPatterns
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
