using System.Text.Json.Serialization;

namespace LoL.Stats.Domain.PreProcessing.Champions
{
    public class ChampionMetadata
    {
        [JsonPropertyName("key")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public Image Image { get; set; }

        [JsonPropertyName("spells")]
        public IEnumerable<SpellMetadata> Spells { get; set; }
    }
}
