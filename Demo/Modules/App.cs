using Demo.Services.Contracts;
using Nancy;

namespace Demo.Modules
{
    public class App : NancyModule
    {
        public App(IMessageService messageService)
        {
            Get["/"] = parameters => messageService.SayHello();
        }
    }
}