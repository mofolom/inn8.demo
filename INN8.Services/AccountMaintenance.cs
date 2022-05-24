using INN8.Api.Dto;
using System.Threading.Tasks;

namespace INN8.Application
{
  public class AccountMaintenance : IAccountMaintenance
  {
    private readonly ICheckWithdrawalRules checkWithdrawalRules;

    public AccountMaintenance(ICheckWithdrawalRules checkWithdrawalRules)
    {
      this.checkWithdrawalRules = checkWithdrawalRules;
    }

    public Task<MaintainRegularContributionResponseDto> MaintainRegularContribution(MaintainRegularContributionDto contributionDto)
    {
      checkWithdrawalRules.Process();

      return Task.FromResult(new MaintainRegularContributionResponseDto());
    }
  }
}
