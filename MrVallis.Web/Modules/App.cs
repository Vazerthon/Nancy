using Nancy;

namespace MrVallis.Web.Modules
{
    public class App : NancyModule
    {
        public App()
        {
            Get["/"] = _ => View;
        }
    }
}