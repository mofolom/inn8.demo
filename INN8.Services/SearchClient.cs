using INN8.Api.Dto;
using INN8.Application.Services;
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
    private readonly IMapper mapper;

    public SearchClient(
      IClientService clientService, 
      IAccountService accountService, 
      ISerialiser serialiser,
      IMapper mapper)
    {
      this.clientService = clientService;
      this.accountService = accountService;
      this.serialiser = serialiser;
      this.mapper = mapper;
    }

    public async Task<SearchClientResponseDto> ProcessAsync<SearchClientResponseDto, SearchClientRequestDto>(SearchClientRequestDto request, CancellationToken cancellationToken)
      where SearchClientResponseDto : class, new()
      where SearchClientRequestDto : class, new()
    {
      var profile = new MappingProfile();
      var searchClientSBSDto = mapper.Map<SearchClientRequestDto, SearchClientSBSDto>(request, profile);

      var searchClientSBSResponseDto = await clientService.SearchClientAsync(searchClientSBSDto, cancellationToken);

      return new SearchClientResponseDto();
    }

    //public async Task<SearchClientResponseDto> SearchClientAsync(SearchClientRequestDto searchClientDto, CancellationToken cancellationToken)
    //{
    //  var searchClientSBSDto = TransForm<SearchClientSBSDto>(searchClientDto);
    //  var getAccountDetailsSBSDto = TransForm<GetAccountDetailsSBSDto>(searchClientDto);

    //  var searchClientSBSResponseDto = await clientService.SearchClient(searchClientSBSDto);
    //  var getAccountDetailsSBSResponseDto = await accountService.GetAccountDetailsAsync(getAccountDetailsSBSDto);

    //  return new SearchClientResponseDto(searchClientSBSResponseDto, getAccountDetailsSBSResponseDto);
    //}

    //private T TransForm<T>(object searchClientDto)
    //{
    //  if (searchClientDto == null)
    //    return default;

    //  return default;
    //}
  }
}
