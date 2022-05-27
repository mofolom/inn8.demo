using INN8.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INN8.Application.AccountMaintenance
{
    public class ValidateRegularWithdrawalStartDate : IValidateRegularWithdrawalStartDate
    {
        public Task<ValidateRegularWithdrawalStartDateResponseDto> ProcessAsync(ValidateRegularWithdrawalStartDateDto request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new ValidateRegularWithdrawalStartDateResponseDto());
        }
    }
}
