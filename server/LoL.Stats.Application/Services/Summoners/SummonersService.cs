using LoL.Stats.Domain.Models.Summoners;
using LoL.Stats.Riot.Api.Services.Summoners;

namespace LoL.Stats.Application.Services.Summoners
{
    public class SummonersService : ISummonersService
    {
        private readonly ISummonersApiService summonersApiService;

        public SummonersService(ISummonersApiService summonersApiService)
        {
            this.summonersApiService = summonersApiService;
        }

        public Task<Summoner> GetSummonerByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
