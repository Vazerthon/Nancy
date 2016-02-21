using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace MrVallis.Web.Startup
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            BundleConfig.Setup();
        }
    }
}