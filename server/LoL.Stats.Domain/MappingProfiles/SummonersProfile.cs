using AutoMapper;
using LoL.Stats.Domain.Models.Summoners;

namespace LoL.Stats.Domain.MappingProfiles
{
    public class SummonersProfile : Profile
    {
        public SummonersProfile()
        {
            CreateMap<Riot.Api.Models.Summoners.Summoner, Summoner>();
        }   
    }
}
