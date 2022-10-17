using LoL.Stats.Riot.Api.Dtos;
using LoL.Stats.Riot.Api.Models.Matches;

namespace LoL.Stats.Riot.Api.Services.Matches
{
    public interface IMatchesApiService
    {
        Task<IEnumerable<string>> GetMatchesBySummonerPuuidAsync(GetMatchesBySummonersPuuidRequest request);

        Task<Match> GetMatchByIdAsync(string matchId);
    }
}
