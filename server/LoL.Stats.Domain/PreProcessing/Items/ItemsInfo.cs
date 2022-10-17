using System.Text.Json.Serialization;

namespace LoL.Stats.Domain.PreProcessing.Items
{
    public class ItemsInfo
    {
        [JsonPropertyName("data")]
        public Dictionary<string, ItemMetadata> Items { get; set; }
    }
}
