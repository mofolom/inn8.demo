using INN8.ThirdParty.Dto.Account;
using INN8.ThirdParty.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace INN8.Application
{

  public class CheckWithdrawalRules : ICheckWithdrawalRules
  {
    private readonly IAccountService accountService;

    public CheckWithdrawalRules(IAccountService accountService )
    {
      this.accountService = accountService;
    }

    public async Task<CheckWithdrawalRulesResponseDto> ProcessAsync<CheckWithdrawalRulesResponseDto, CheckWithdrawalRulesDto>(CheckWithdrawalRulesDto request, CancellationToken cancellationToken)
      where CheckWithdrawalRulesResponseDto : class, new()
      where CheckWithdrawalRulesDto : class, new()
    {


      return new CheckWithdrawalRulesResponseDto();
    }

    //public async Task<T> ProcessAsync<T, U>(U input, CancellationToken cancellationToken)
    //{
    //  var getAccountDetailsSBSDto = new GetAccountDetailsSBSDto();
    //  var getAccountDetailsSBSResponseDto = await accountService.GetAccountDetailsAsync(getAccountDetailsSBSDto, cancellationToken);

    //  return 
    //}
  }
}
