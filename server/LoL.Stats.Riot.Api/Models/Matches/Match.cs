using System.Text.Json.Serialization;

namespace LoL.Stats.Riot.Api.Models.Matches
{
    public class Match
    {
        [JsonPropertyName("info")]
        public MatchInfo Info { get; set; }
    }
}
