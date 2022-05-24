using INN8.Api.Dto;
using INN8.ThirdParty.Dto;
using INN8.ThirdParty.Dto.Account;
using INN8.ThirdParty.Services;
using System.Threading;
using System.Threading.Tasks;

namespace INN8.Application
{
  public class SearchClient : ISearchClient
  {
    private readonly IClientService clientService;
    private readonly IAccountService accountService;
    private readonly ISerialiser serialiser;

    public SearchClient(
      IClientService clientService, 
      IAccountService accountService, 
      ISerialiser serialiser)
    {
      this.clientService = clientService;
      this.accountService = accountService;
      this.serialiser = serialiser;
    }

    public async Task<SearchClientResponseDto> SearchClientAsync(SearchClientRequestDto searchClientDto, CancellationToken cancellationToken)
    {
      var searchClientSBSDto = TransForm<SearchClientSBSDto>(searchClientDto);
      var getAccountDetailsSBSDto = TransForm<GetAccountDetailsSBSDto>(searchClientDto);

      var searchClientSBSResponseDto = await clientService.SearchClient(searchClientSBSDto);
      var getAccountDetailsSBSResponseDto = await accountService.GetAccountDetails(getAccountDetailsSBSDto);

      return new SearchClientResponseDto(searchClientSBSResponseDto, getAccountDetailsSBSResponseDto);
    }

    private T TransForm<T>(object searchClientDto)
    {
      if (searchClientDto == null)
        return default;

      return default;
    }
  }
}
