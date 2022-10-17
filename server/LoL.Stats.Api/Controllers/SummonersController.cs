using LoL.Stats.Application.Services.Matches;
using LoL.Stats.Application.Services.Summoners;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LoL.Stats.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SummonersController : ControllerBase
    {
        private readonly ISummonersService summonersService;
        private readonly IMatchesService matchesService;

        public SummonersController(ISummonersService summonersService, IMatchesService matchesService)
        {
            this.summonersService = summonersService;
            this.matchesService = matchesService;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetSummonerInfoAsync(string name)
        {
            var summoner = await summonersService.GetSummonerByNameAsync(name);
            if (summoner == null)
            {
                return NotFound();
            }

            return Ok(summoner);
        }

        [HttpGet("{puuid}/matches")]
        public async Task<IActionResult> GetSummonersMatchesAsync(string puuid, [FromQuery] int count = 5)
        {
            if (string.IsNullOrEmpty(puuid))
            {
                return BadRequest("Summoner Id is required.");
            }

            var matches = await matchesService.GetMatches(puuid, count);
            return Ok(matches);
        }
    }
}
