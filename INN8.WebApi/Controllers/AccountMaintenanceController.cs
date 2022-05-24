using INN8.Api.Dto;
using INN8.Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INN8.WebApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class AccountMaintenanceController : ControllerBase
  {
    private readonly IAccountMaintenance accountMaintenance;

    public AccountMaintenanceController(IAccountMaintenance accountMaintenance)
    {
      this.accountMaintenance = accountMaintenance;
    }

    public async Task<IActionResult> MaintainRegularContribution(MaintainRegularContributionDto contributionDto)
    {
      return Ok(await accountMaintenance.MaintainRegularContribution(contributionDto));
    }
  }
}
