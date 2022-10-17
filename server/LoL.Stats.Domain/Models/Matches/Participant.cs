using LoL.Stats.Domain.Models.Champions;

namespace LoL.Stats.Domain.Models.Matches
{
    public class Participant
    {
        public string Name { get; set; }

        public SummonerChampion Champion { get; set; }
    }
}
