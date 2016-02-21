using MrVallis.Web.Services.Contracts;
using Nancy;

namespace MrVallis.Web.Modules
{
    public class App : NancyModule
    {
        readonly IModelService modelService;

        public App(IModelService modelService)
        {
            this.modelService = modelService;
            ConfigureRoutes();
        }

        void ConfigureRoutes()
        {
            Get["/"] = _ => View[modelService.GetHomePageModel()];
        }
    }
}