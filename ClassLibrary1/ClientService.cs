using INN8.ThirdParty.Dto;
using INN8.ThirdParty.Dto.SeachClient;
using INN8.ThirdParty.Services;
using INN8.ThirdPartyApi.Dto;
using System;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  public class ClientService : IClientService
  {
    public Task<CreateClientSBSResponseDto> CreateClient(CreateClientSBSDto createClientSBSDto)
    {
      return Task.FromResult(new CreateClientSBSResponseDto());
    }

    public Task<SaveClientSBSResponseDto> SaveClient(SaveClientSBSDto saveClientSBSDto)
    {
      return Task.FromResult(new SaveClientSBSResponseDto());
    }

    public Task<SearchClientSBSResponseDto> SearchClient(SearchClientSBSDto searchClientSBSDto)
    {
      return Task.FromResult(new SearchClientSBSResponseDto());
    }
  }
}
