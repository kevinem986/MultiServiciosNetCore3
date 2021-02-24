using Customer.Domain;
using Customer.Persistence.Database;
using Customer.Services.EventHandlers.Commands;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Services.EventHandlers
{
    public class ClientEventHandler : INotificationHandler<ClientCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ClientEventHandler(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ClientCreateCommand notification, CancellationToken cancelationToken)
        {
            await _context.AddAsync(new Client
            {
                Name = notification.Name
            });

            await _context.SaveChangesAsync();
        }
    }
}
