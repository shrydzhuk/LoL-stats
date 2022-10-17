using System.Text.Json.Serialization;

namespace LoL.Stats.Riot.Api.Models.Matches
{
    public class Team
    {
        [JsonPropertyName("teamId")]
        public int TeamId { get; set; }

        [JsonPropertyName("win")]
        public bool Win { get; set; }
    }
}
