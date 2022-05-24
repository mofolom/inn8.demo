using INN8.ThirdParty.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace INN8.Application
{

  public class CheckWithdrawalRules : ICheckWithdrawalRules
  {
    private readonly IAccountService accountService;

    public CheckWithdrawalRules(IAccountService accountService )
    {
      this.accountService = accountService;
    }

    public void Process()
    {
      throw new NotImplementedException();
    }
  }
}
