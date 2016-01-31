using System.Collections.Generic;
using Demo.Models;
using Demo.Services.Contracts;

namespace Demo.Services.Implementations
{
    public class ModelService : IModelService
    {
        const string CommonPageTitlePostfix = "| Nancy Demo";

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