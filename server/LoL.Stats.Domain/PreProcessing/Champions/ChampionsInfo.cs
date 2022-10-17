using System.Text.Json.Serialization;

namespace LoL.Stats.Domain.PreProcessing.Champions
{
    public class ChampionsInfo
    {
        [JsonPropertyName("data")]
        public Dictionary<string, ChampionMetadata> Champions { get; set; }
    }
}
