using INN8.Api.Dto;
using INN8.Application.Client;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace INN8.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        [Route("SearchClient")]
        public async Task<IActionResult> SearchClient([FromServices] ISearchClientDomainService searchClient, CancellationToken cancellationToken)
        {
            var t = Request;
            var request = new SearchClientRequestDto
            {
                accountNo = "IA100639"
            };

            var result = await searchClient.ProcessAsync(request, cancellationToken);

            return Ok(result);
        }
    }
}
