using Customer.Service.Queries.DTOs;
using Customer.Services.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Common.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Api.Controllers
{
    [ApiController]
    [Route("v1/clients")]
    public class ClientController : ControllerBase
    {
        private readonly IClientQueryService _clientQuerService;
        private readonly ILogger<ClientController> _logger;

        public ClientController(
            ILogger<ClientController> logger,
             IClientQueryService clientQuerService)
        {
            _logger = logger;
            _clientQuerService = clientQuerService;

        }

        [HttpGet]
        public async Task<DataCollection<ClientDto>> GetAll(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<int> clients = null;

            if (!string.IsNullOrEmpty(ids))
            {
                clients = ids.Split(',').Select(x => Convert.ToInt32(x));
            }

            return await _clientQuerService.GetAllAsync(page, take, clients);
        }

        [HttpGet("{id}")]
        public async Task<ClientDto> Get(int id)
        {
            return await _clientQuerService.GetAsync(id);
        }
    }
}
