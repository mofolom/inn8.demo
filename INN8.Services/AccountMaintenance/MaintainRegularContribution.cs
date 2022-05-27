using INN8.Api.Dto;

namespace INN8.Application.AccountMaintenance
{
    public class MaintainRegularContribution : IMaintainRegularContribution
    {
        public MaintainRegularContribution()
        {

        }

        public async Task<MaintainRegularContributionResponseDto> ProcessAsync(MaintainRegularContributionDto request, CancellationToken cancellationToken)
        {
            return new MaintainRegularContributionResponseDto();
        }
    }
}
