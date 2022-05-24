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

    public async Task<IActionResult> SearchClient(SearchClientRequestDto searchClientDto, CancellationToken cancellationToken)
    {
      var output = await searchClient.SearchClientAsync(searchClientDto, cancellationToken);

      return Ok(output);
    }
  }
}
