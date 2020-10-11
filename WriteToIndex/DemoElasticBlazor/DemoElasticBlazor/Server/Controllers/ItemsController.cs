using DemoElasticBlazor.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Nest;
using System;
using System.Threading.Tasks;

namespace DemoElasticBlazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILogger<ItemsController> logger;

        /// <summary>
        /// The client
        /// </summary>
        private readonly ElasticClient _elasticClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsController" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public ItemsController(ILogger<ItemsController> logger, IConfiguration configuration)
        {
            this.logger = logger;

            var node = new Uri(configuration.GetValue<string>("Elastic"));
            var settings = new ConnectionSettings(node);
            _elasticClient = new ElasticClient(settings);
        }

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="itemDto">The item dto.</param>
        [HttpPost]
        public async Task AddItem([FromBody] ItemDto itemDto)
        {
            string indexToWrite = "item_entry_log";

            IndexRequest<ItemDto> indexRequest = new IndexRequest<ItemDto>(indexToWrite, Guid.NewGuid())
            {
                Document = itemDto
            };

            var indexResult = await _elasticClient.IndexAsync<ItemDto>(indexRequest);

            if (!indexResult.IsValid)
            {
                logger.LogError(indexResult.DebugInformation);
            }
            else
            {
                logger.LogInformation(indexResult.DebugInformation);
            }
        }
     }
}
