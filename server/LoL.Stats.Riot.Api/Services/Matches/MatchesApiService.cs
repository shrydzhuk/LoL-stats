using LoL.Stats.Riot.Api.Dtos;
using LoL.Stats.Riot.Api.Models.Matches;

namespace LoL.Stats.Riot.Api.Services.Matches
{
    public class MatchesApiService : IMatchesApiService
    {
        public Task<Match> GetMatchByIdAsync(string matchId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetMatchesBySummonerPuuidAsync(GetMatchesBySummonersPuuidRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
