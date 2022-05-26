using INN8.Api.Dto;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace INN8.Application
{
  public interface ISearchClient : IDomainService
  {
    //Task<SearchClientResponseDto> SearchClientAsync(SearchClientRequestDto searchClientDto, CancellationToken cancellationToken);
  }
}
