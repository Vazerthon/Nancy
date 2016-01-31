using Demo.Services.Contracts;
using Nancy;

namespace Demo.Modules
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