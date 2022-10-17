using LoL.Stats.Domain.Models.Matches;

namespace LoL.Stats.Application.Services.Matches
{
    public interface IMatchesService
    {
        Task<IEnumerable<SummonerMatch>> GetMatches(string puuid, int count);
    }
}
