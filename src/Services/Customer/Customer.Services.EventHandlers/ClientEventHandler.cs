using Customer.Domain;
using Customer.Persistence.Database;
using Customer.Services.EventHandlers.Commands;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Customer.Services.EventHandlers
{
    public class ClientEventHandler : INotificationHandler<ClientCreateCommand>
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ClientEventHandler> _logger;

        public ClientEventHandler(
            ApplicationDbContext context,
            ILogger<ClientEventHandler> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task Handle(ClientCreateCommand notification, CancellationToken cancelationToken)
        {
            _logger.LogInformation("--- New client creation started");

            await _context.AddAsync(new Client
            {
                Name = notification.Name
            });

            await _context.SaveChangesAsync();

            _logger.LogInformation($"--- Client: {notification.Name} was created");
            _logger.LogInformation("--- New client creation ended");
        }
    }
}
