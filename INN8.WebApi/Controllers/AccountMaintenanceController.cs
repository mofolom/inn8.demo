using INN8.Api.Dto;
using INN8.Application.AccountMaintenance;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace INN8.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountMaintenanceController : ControllerBase
    {
        
        [HttpPost("MaintainRegularContribution")]
        public async Task<IActionResult> MaintainRegularContribution([FromServices] IMaintainRegularContribution maintainRegularContribution, 
            MaintainRegularContributionDto contributionDto, CancellationToken cancellationToken)
        {
            return Ok(await maintainRegularContribution.ProcessAsync(contributionDto, cancellationToken));
        }

        [HttpPost("MaintainRegularContribution")]
        public async Task<IActionResult> MaintainRegularWithdrawal([FromServices] IMaintainRegularWithdrawal maintainRegularWithdrawal,
            MaintainRegularWithdrawalDto regularWithdrawalDto, CancellationToken cancellationToken)
        {
            return Ok(await maintainRegularWithdrawal.ProcessAsync(regularWithdrawalDto, cancellationToken));
        }

        [HttpPost("ValidateRegularWithdrawalStartDate")]
        public async Task<IActionResult> ValidateRegularWithdrawalStartDate([FromServices] IValidateRegularWithdrawalStartDate validateRegularWithdrawal,
            ValidateRegularWithdrawalStartDateDto withdrawalStartDateDto, CancellationToken cancellationToken)
        {
            return Ok(await validateRegularWithdrawal.ProcessAsync(withdrawalStartDateDto, cancellationToken));
        }
    }
}
