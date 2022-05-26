using INN8.Api.Dto;
using INN8.ThirdParty.Dto;
using System.Threading;
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

    public async Task<MaintainRegularContributionResponseDto> ProcessAsync<MaintainRegularContributionResponseDto, MaintainRegularContributionDto>(MaintainRegularContributionDto input, CancellationToken cancellationToken)
      where MaintainRegularContributionResponseDto : class, new()
      where MaintainRegularContributionDto : class, new()
    {
      var request = new CheckWithdrawalRulesDto();
      var res = await checkWithdrawalRules.ProcessAsync<CheckWithdrawalRulesResponseDto,CheckWithdrawalRulesDto>(request, cancellationToken);

      return new MaintainRegularContributionResponseDto();
    }
  }
}
