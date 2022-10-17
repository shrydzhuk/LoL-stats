using LoL.Stats.Domain.Models.Champions;
using LoL.Stats.Domain.Models.Matches;
using LoL.Stats.Riot.Api.Dtos;
using LoL.Stats.Riot.Api.Services.Matches;

namespace LoL.Stats.Application.Services.Matches
{
    public class MatchesService : IMatchesService
    {
        private IMatchesApiService apiService;

        public MatchesService()
        {
            apiService = new MatchesApiService();
        }

        public async Task<IEnumerable<SummonerMatch>> GetMatches(string puuid, int count)
        {
            var request = new GetMatchesBySummonersPuuidRequest()
            {
                Puuid = puuid,
                Count = count
            };

            var result = new List<SummonerMatch>();
            var matchIds = await apiService.GetMatchesBySummonerPuuidAsync(request);
            foreach (var matchId in matchIds)
            {
                var matchInfo = await GetMatchById(matchId, puuid);
                result.Add(matchInfo);
            }

            return result;
        }

        private async Task<SummonerMatch> GetMatchById(string id, string summonerId)
        {
            var riotMatch = await apiService.GetMatchByIdAsync(id);
            if (riotMatch == null)
            {
                return null;
            }

            var summoner = riotMatch.Info?.Participants?.FirstOrDefault(x => x.Puuid == summonerId);
            if (summoner == null)
            {
                return null;
            }

            var match = new SummonerMatch()
            {
                Kills = summoner.Kills,
                Assists = summoner.Assists,
                Deaths = summoner.Deaths,
                Win = summoner.Win,
                Lane = summoner.Lane,
                Role = summoner.Role,
                TotalDamageDealtToChampions = summoner.TotalDamageDealtToChampions,
                Name = summoner.SummonerName,
                Date = DateTimeOffset.FromUnixTimeMilliseconds(riotMatch.Info.GameCreation).UtcDateTime,
                Duration = riotMatch.Info.GameDuration,
                Champion = new SummonerChampion()
                {
                    Name = summoner.ChampionName,
                    Level = summoner.ChampLevel
                }
            };

            return match;
        }
    }
}
