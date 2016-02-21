using System.IO;
using System.Text;
using Nancy;
using SquishIt.Framework;

namespace MrVallis.Web.Modules
{
    public class Assets : NancyModule
    {
        public Assets() : base("/assets")
        {
            Get["/js/{name}"] = parameters => CreateResponse(Bundle.JavaScript().RenderCached(parameters.name as string), Configuration.Instance.JavascriptMimeType);
        }

        Response CreateResponse(string content, string contentType)
        {
            return Response
                .FromStream(() => new MemoryStream(Encoding.UTF8.GetBytes(content)), contentType)
                .WithHeader("Cache-Control", "max-age=45");
        }
    }
}