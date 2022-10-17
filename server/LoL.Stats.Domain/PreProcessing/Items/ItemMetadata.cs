using System.Text.Json.Serialization;

namespace LoL.Stats.Domain.PreProcessing.Items
{
    public class ItemMetadata
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public Image Image { get; set; }
    }
}
