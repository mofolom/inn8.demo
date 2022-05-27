using INN8.Api.Dto;
using INN8.Application.Core.Model;
using INN8.Application.Services.Domain;
using INN8.Application.Services.ThirdParty.SBS.Client;
using INN8.ThirdParty.Dto.Account;
using INN8.ThirdParty.Dto.Client;
using INN8.ThirdParty.Dto.ClientService;
using System.Threading;
using System.Threading.Tasks;

namespace INN8.Application.Client;

public class SearchClient : ISearchClientDomainService
{
    private readonly ISearchClient searchClient;
    private readonly IMapper mapper;

    public SearchClient(ISearchClient searchClient, IMapper mapper)
    {
        this.searchClient = searchClient;
        this.mapper = mapper;
    }

    public async Task<SearchClientResponseDto> ProcessAsync(SearchClientRequestDto request, CancellationToken cancellationToken)
    {
        var profile = new MappingProfile();
        var searchClientSBSDto = mapper.Map<SearchClientRequestDto, ClientSearchClientSBSDto>(request, profile);

        var searchClientSBSResponseDto = await searchClient.ProcessAsync(searchClientSBSDto, cancellationToken);

        return new SearchClientResponseDto();
    }
}
