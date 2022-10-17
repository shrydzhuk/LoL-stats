using LoL.Stats.Domain.Models.Summoners;

namespace LoL.Stats.Application.Services.Summoners
{
    public interface ISummonersService
    {
        Task<Summoner> GetSummonerByNameAsync(string name);
    }
}
