using System.Text.Json.Serialization;

namespace LoL.Stats.Domain.PreProcessing.Champions
{
    public class SpellMetadata
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public Image Image { get; set; }
    }
}
