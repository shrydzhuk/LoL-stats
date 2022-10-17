using AutoMapper;
using LoL.Stats.Domain.Models.Summoners;
using LoL.Stats.Riot.Api.Services.Summoners;

namespace LoL.Stats.Application.Services.Summoners
{
    public class SummonersService : ISummonersService
    {
        private readonly ISummonersApiService summonersApiService;
        private readonly IMapper mapper;

        public SummonersService(IMapper mapper)
        {
            summonersApiService = new SummonersApiService();
            this.mapper = mapper;
        }

        public async Task<Summoner> GetSummonerByNameAsync(string name)
        {
            var summoner = await summonersApiService.GetSummonerByNameAsync(name);
            return mapper.Map<Summoner>(summoner);
        }
    }
}
