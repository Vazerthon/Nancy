using System.Collections.Generic;
using MrVallis.Web.Models;
using MrVallis.Web.Services.Contracts;

namespace MrVallis.Web.Services.Implementations
{
    public class ModelService : IModelService
    {
        const string CommonPageTitlePostfix = "| MrVallis";

        public HomePageModel GetHomePageModel()
        {
            return new HomePageModel
            {
                Title = $"Home Page {CommonPageTitlePostfix}",
                Items = new List<string> { "Foo", "Bar", "More Foo", "More Bar" }
            };
        }
    }
}