using LoL.Stats.Domain.Models.Matches;

namespace LoL.Stats.Application.Services.Matches
{
    public class MatchesService : IMatchesService
    {
        public Task<IEnumerable<SummonerMatch>> GetMatches(string puuid, int count)
        {
            throw new NotImplementedException();
        }
    }
}
