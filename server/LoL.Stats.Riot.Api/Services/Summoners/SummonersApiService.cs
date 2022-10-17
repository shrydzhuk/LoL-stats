using LoL.Stats.Riot.Api.Core;
using LoL.Stats.Riot.Api.Models.Summoners;
using LoL.Stats.Riot.Api.Utils;

namespace LoL.Stats.Riot.Api.Services.Summoners
{
    public class SummonersApiService : ISummonersApiService
    {
        private readonly RiotClient riotClient;

        public SummonersApiService()
        {
            riotClient = new RiotClient();
        }

        public async Task<Summoner> GetSummonerByNameAsync(string name)
        {
            var url = string.Format(Urls.GetSummonerByNameUrl, name);
            return await riotClient.GetAsync<Summoner>(url);
        }
    }
}
