using INN8.Api.Dto;
using System.Threading.Tasks;

namespace INN8.Application
{
  public interface IAccountMaintenance
  {
    Task<MaintainRegularContributionResponseDto> MaintainRegularContribution(MaintainRegularContributionDto contributionDto);
  }
}
