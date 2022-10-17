using System.Text.Json.Serialization;

namespace LoL.Stats.Riot.Api.Models.Summoners
{
    public class Summoner
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("puuid")]
        public string Puuid { get; set; }

        [JsonPropertyName("accountId")]
        public string AccountId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("summonerLevel")]
        public long SummonerLevel { get; set; }

        [JsonPropertyName("profileIconId")]
        public long ProfileIconId { get; set; }

        [JsonPropertyName("revisionDate")]
        public long RevisionDate { get; set; }
    }
}
