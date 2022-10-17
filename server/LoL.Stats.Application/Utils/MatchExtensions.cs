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

        public static Participant ToDomainParticipant(this Riot.Api.Models.Matches.Participant riotParticipant)
        {
            return new Participant()
            {
                Name = riotParticipant.SummonerName,
                Champion = new SummonerChampion()
                {
                    Name = riotParticipant.ChampionName,
                    Level = riotParticipant.ChampLevel,
                    Image = null // TODO: Get image name from static files
                }
            };
        }

        public static IEnumerable<Item> GetItems(this Riot.Api.Models.Matches.Participant riotParticipant)
        {
            var items = new List<Item>()
            {
                GetItem(riotParticipant.Item0),
                GetItem(riotParticipant.Item1),
                GetItem(riotParticipant.Item2),
                GetItem(riotParticipant.Item3),
                GetItem(riotParticipant.Item4),
                GetItem(riotParticipant.Item5),
                GetItem(riotParticipant.Item6)
            };

            return items.Where(x => x != null);
        }

        private static Item GetItem(int itemId)
        {
            // TODO: Get info from static files
            return null;
        }
    }
}
