using INN8.Application.Services;
using INN8.Application.Services.ThirdParty.SBS.Client;
using INN8.ThirdParty.Dto.Client;
using INN8.ThirdParty.Services.SBS.Client;
using System.Net.Http;

namespace INN8.ThirdParty.Services.Infrustructure.ThirdParty.SBS.Client;

public class SearchClient : ISearchClient
{
    private readonly HttpClient httpClient;

    public SearchClient(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<ClientSearchClientSBSResponseDto> ProcessAsync(ClientSearchClientSBSDto request, CancellationToken cancellationToken)
    {
        using var client = await httpClient.GetAsync(string.Empty, cancellationToken);

        return new ClientSearchClientSBSResponseDto();
    }
}
