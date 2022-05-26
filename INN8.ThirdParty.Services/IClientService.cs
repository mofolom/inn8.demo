using INN8.ThirdParty.Dto;
using INN8.ThirdParty.Dto.SeachClient;
using INN8.ThirdPartyApi.Dto;
using System.Threading;
using System.Threading.Tasks;

namespace INN8.ThirdParty.Services
{
  public interface IClientService
  {
    Task<SearchClientSBSResponseDto> SearchClientAsync(SearchClientSBSDto searchClientSBSDto, CancellationToken cancellationToken);
  }
}
