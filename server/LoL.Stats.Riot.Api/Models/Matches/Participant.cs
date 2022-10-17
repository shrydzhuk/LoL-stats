using System.Text.Json.Serialization;

namespace LoL.Stats.Riot.Api.Models.Matches
{
    public class Participant
    {
        [JsonPropertyName("assists")]
        public int Assists { get; set; }

        [JsonPropertyName("champLevel")]
        public int ChampLevel { get; set; }

        [JsonPropertyName("championId")]
        public int ChampionId { get; set; }

        [JsonPropertyName("championName")]
        public string ChampionName { get; set; }

        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }

        [JsonPropertyName("item0")]
        public int Item0 { get; set; }

        [JsonPropertyName("item1")]
        public int Item1 { get; set; }

        [JsonPropertyName("item2")]
        public int Item2 { get; set; }

        [JsonPropertyName("item3")]
        public int Item3 { get; set; }

        [JsonPropertyName("item4")]
        public int Item4 { get; set; }

        [JsonPropertyName("item5")]
        public int Item5 { get; set; }

        [JsonPropertyName("item6")]
        public int Item6 { get; set; }

        [JsonPropertyName("kills")]
        public int Kills { get; set; }

        [JsonPropertyName("lane")]
        public string Lane { get; set; }

        [JsonPropertyName("puuid")]
        public string Puuid { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("spell1Casts")]
        public int Spell1Casts { get; set; }

        [JsonPropertyName("spell2Casts")]
        public int Spell2Casts { get; set; }

        [JsonPropertyName("spell3Casts")]
        public int Spell3Casts { get; set; }

        [JsonPropertyName("spell4Casts")]
        public int Spell4Casts { get; set; }

        [JsonPropertyName("summonerName")]
        public string SummonerName { get; set; }

        [JsonPropertyName("teamId")]
        public int TeamId { get; set; }

        [JsonPropertyName("totalDamageDealtToChampions")]
        public int TotalDamageDealtToChampions { get; set; }

        [JsonPropertyName("win")]
        public bool Win { get; set; }
    }
}
