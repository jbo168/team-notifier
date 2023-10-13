using Microsoft.AspNetCore.Mvc;
using Team.Notifier.Core;

namespace Team.Notifier.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ILogger<TeamController> _logger;
        private readonly ITeamService _teamService;

        public TeamController(ILogger<TeamController> logger, ITeamService teamService)
        {
            _logger = logger;
            _teamService = teamService;
        }

        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<IEnumerable<Common.Team>>> GetAll()
        {
            var teams = await _teamService.GetAllTeams();

            return Ok(teams);
        }
    }
}