using LoL.Stats.Domain.Models.Matches;
using LoL.Stats.Riot.Api.Services.Matches;

namespace LoL.Stats.Application.Services.Matches
{
    public class MatchesService : IMatchesService
    {
        private readonly IMatchesApiService matchesApiService;

        public MatchesService()
        {
            matchesApiService = new MatchesApiService();
        }

        public Task<IEnumerable<SummonerMatch>> GetMatches(string puuid, int count)
        {
            throw new NotImplementedException();
        }
    }
}
