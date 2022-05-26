using INN8.Api.Dto;
using INN8.Application;
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
    private readonly ISearchClient searchClient;

    public ClientController(ISearchClient searchClient)
    {
      this.searchClient = searchClient;
    }

    [HttpGet]
    [Route("[action]/searchclient", Name = "SearchClient")]
    public async Task<IActionResult> SearchClient(CancellationToken cancellationToken)
    {
      var t = Request;
      var request = new SearchClientRequestDto
      {
        accountNo = "IA100639"
      };

      var result = await searchClient.ProcessAsync<SearchClientResponseDto, SearchClientRequestDto>(request, cancellationToken);

      return Ok(result);
    }
  }
}
