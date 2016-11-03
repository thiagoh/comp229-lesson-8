using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comp229_lesson_8.Startup))]
namespace comp229_lesson_8 {
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
