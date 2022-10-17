using LoL.Stats.Application.Services.Summoners;
using Microsoft.AspNetCore.Mvc;

namespace LoL_stats.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SummonerController : ControllerBase
    {
        private readonly ISummonersService summonersService;

        public SummonerController(ISummonersService summonersService)
        {
            this.summonersService = summonersService;
        }
    }
}
