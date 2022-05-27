using INN8.Api.Dto;

namespace INN8.Application.AccountMaintenance
{
    public class MaintainRegularWithdrawal : IMaintainRegularWithdrawal
    {
        public Task<MaintainRegularWithdrawalResponseDto> ProcessAsync(MaintainRegularWithdrawalDto request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new MaintainRegularWithdrawalResponseDto());
        }
    }
}
