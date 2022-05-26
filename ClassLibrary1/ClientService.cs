using INN8.ThirdParty.Dto;
using INN8.ThirdParty.Dto.SeachClient;
using INN8.ThirdParty.Services;
using INN8.ThirdPartyApi.Dto;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  public class ClientService : IClientService
  {

    public Task<SearchClientSBSResponseDto> SearchClientAsync(SearchClientSBSDto searchClientSBSDto, CancellationToken cancellationToken)
    {
      return Task.FromResult(new SearchClientSBSResponseDto());
    }
  }
}
