using Nancy;
using SquishIt.Framework;

namespace MrVallis.Web.Modules
{
    public class App : NancyModule
    {
        public App()
        {
            Get["/"] = _ => View["Home", new
            {
                JsBundle = Bundle.JavaScript().RenderNamed("js")
            }];
        }
    }
}