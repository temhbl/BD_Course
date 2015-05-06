using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(КурсоваяРабота.Startup))]
namespace КурсоваяРабота
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
