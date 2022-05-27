using INN8.Api.Dto;
using INN8.Application.Core;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace INN8.Application.Client;

public interface ISearchClientDomainService : IDomainService<SearchClientResponseDto, SearchClientRequestDto>
{
    //Task<SearchClientResponseDto> SearchClientAsync(SearchClientRequestDto searchClientDto, CancellationToken cancellationToken);
}
