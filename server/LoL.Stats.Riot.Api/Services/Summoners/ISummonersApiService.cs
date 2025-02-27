﻿using LoL.Stats.Riot.Api.Models.Summoners;

namespace LoL.Stats.Riot.Api.Services.Summoners
{
    public interface ISummonersApiService
    {
        Task<Summoner> GetSummonerByNameAsync(string name);
    }
}
