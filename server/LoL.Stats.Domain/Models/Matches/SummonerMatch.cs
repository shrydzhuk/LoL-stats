using LoL.Stats.Domain.Models.Champions;

namespace LoL.Stats.Domain.Models.Matches
{
    public class SummonerMatch
    {
        public string Name { get; set; }
        public bool Win { get; set; }

        public long Duration { get; set; }
        public DateTime Date { get; set; }

        public int Kills { get; set; }
        public int Assists { get; set; }
        public int Deaths { get; set; }

        public int TotalDamageDealtToChampions { get; set; }
        public string Lane { get; set; }
        public string Role { get; set; }

        public SummonerChampion Champion { get; set; }
        public IEnumerable<Team> Teams { get; set; }
    }
}
