using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoteForWords.Startup))]
namespace VoteForWords
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
