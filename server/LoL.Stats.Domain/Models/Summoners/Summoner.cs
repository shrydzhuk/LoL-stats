namespace LoL.Stats.Domain.Models.Summoners
{
    public class Summoner
    {
        public string Id { get; set; }
        public string Puuid { get; set; }
        public string Name { get; set; }
        public int ProfileIconId { get; set; }
        public int SummonerLevel { get; set; }
    }
}
