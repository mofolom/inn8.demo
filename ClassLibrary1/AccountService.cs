using INN8.ThirdParty.Dto.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INN8.ThirdParty.Services.Infrustructure
{
  public class AccountService : IAccountService
  {
    public Task<GetAccountDetailsSBSResponseDto> GetAccountDetailsAsync(GetAccountDetailsSBSDto getAccountDetailsSBSDto)
    {
      return Task.FromResult(new GetAccountDetailsSBSResponseDto());
    }
  }
}
