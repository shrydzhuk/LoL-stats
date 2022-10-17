using LoL.Stats.Application.PreProcessors;
using LoL.Stats.Domain.Models.Champions;
using LoL.Stats.Riot.Api.Models.Matches;
using Participant = LoL.Stats.Domain.Models.Matches.Participant;
using Team = LoL.Stats.Domain.Models.Matches.Team;

namespace LoL.Stats.Application.Utils
{
    public static class MatchExtensions
    {
        public static IEnumerable<Team> GetTeams(this Match match)
        {
            var teams = new List<Team>();
            var groupedByTeams = match.Info.Participants.GroupBy(x => x.TeamId).ToDictionary(x => x.Key, x => x.ToList());
            foreach (var teamGroup in groupedByTeams)
            {
                teams.Add(new Team()
                {
                    Participants = new List<Participant>(teamGroup.Value.Select(x => x.ToDomainParticipant()))
                });
            }

            return teams;
        }

        public static Participant ToDomainParticipant(this Riot.Api.Models.Matches.Participant riotParticipant, IStaticInfoHandler staticInfoHandler = null)
        {
            var championImage = staticInfoHandler?.GetChampionInfo(riotParticipant.ChampionName)?.Image?.Full;

            return new Participant()
            {
                Name = riotParticipant.SummonerName,
                Champion = new SummonerChampion()
                {
                    Name = riotParticipant.ChampionName,
                    Level = riotParticipant.ChampLevel,
                    Image = championImage
                }
            };
        }

        public static IEnumerable<Item> GetItems(this Riot.Api.Models.Matches.Participant riotParticipant, IStaticInfoHandler staticInfoHandler)
        {
            var items = new List<Item>()
            {
                GetItem(riotParticipant.Item0, staticInfoHandler),
                GetItem(riotParticipant.Item1, staticInfoHandler),
                GetItem(riotParticipant.Item2, staticInfoHandler),
                GetItem(riotParticipant.Item3, staticInfoHandler),
                GetItem(riotParticipant.Item4, staticInfoHandler),
                GetItem(riotParticipant.Item5, staticInfoHandler),
                GetItem(riotParticipant.Item6, staticInfoHandler)
            };

            return items.Where(x => x != null);
        }

        private static Item GetItem(int itemId, IStaticInfoHandler staticInfoHandler)
        {
            var itemInfo = staticInfoHandler.GetItemInfo(itemId);
            if (itemInfo == null)
            {
                return null;
            }

            return new Item()
            {
                Name = itemInfo.Name,
                Image = itemInfo.Image?.Full
            };
        }
    }
}
