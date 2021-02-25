using MediatR;

namespace Customer.Services.EventHandlers.Commands
{
    public class ClientCreateCommand : INotification
    {
        public string Name { get; set; }
    }
}
