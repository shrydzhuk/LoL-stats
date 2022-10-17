using LoL.Stats.Riot.Api.Core;
using LoL.Stats.Riot.Api.Dtos;
using LoL.Stats.Riot.Api.Models.Matches;
using LoL.Stats.Riot.Api.Utils;

namespace LoL.Stats.Riot.Api.Services.Matches
{
    public class MatchesApiService : IMatchesApiService
    {
        private readonly RiotClient riotClient;

        public MatchesApiService()
        {
            riotClient = new RiotClient();
        }

        public async Task<IEnumerable<string>> GetMatchesBySummonerPuuidAsync(GetMatchesBySummonersPuuidRequest request)
        {
            try
            {
                var url = string.Format($"{Urls.GetMatchesBySummonerPuuidUrl}{request.GetQueryString()}", request.Puuid);
                return await riotClient.GetAsync<IEnumerable<string>>(url);
            }
            catch (Exception ex)
            {
                // TODO: Log(ex);
                return Array.Empty<string>();
            }
        }

        public async Task<Match> GetMatchByIdAsync(string matchId)
        {
            try
            {
                var url = string.Format(Urls.GetMatchByIdUrl, matchId);
                return await riotClient.GetAsync<Match>(url);
            }
            catch (Exception ex)
            {
                // TODO: Log(ex);
                return null;
            }
        }
    }
}
