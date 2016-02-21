using SquishIt.Framework;

namespace MrVallis.Web.Startup
{
    internal static class BundleConfig
    {
        internal static void Setup()
        {
            Bundle.JavaScript()
                .Add("~/Scripts/Packages/Angular/angular.js")
                .ForceRelease().AsCached("js", "~/assets/js");
        }
    }
}