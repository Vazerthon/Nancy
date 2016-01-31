using Demo.Services.Contracts;

namespace Demo.Services.Implementations
{
    public class MessageService : IMessageService
    {
        public string SayHello()
        {
            return "Hello Service World";
        }
    }
}