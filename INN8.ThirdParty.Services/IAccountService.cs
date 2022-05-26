using INN8.ThirdParty.Dto.Account;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace INN8.ThirdParty.Services
{

  public interface IAccountService
  {
    Task<GetAccountDetailsSBSResponseDto> GetAccountDetailsAsync(GetAccountDetailsSBSDto getAccountDetailsSBSDto, CancellationToken cancellationToken);
  }
}
