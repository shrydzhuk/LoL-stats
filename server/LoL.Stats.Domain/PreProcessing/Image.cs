using System.Text.Json.Serialization;

namespace LoL.Stats.Domain.PreProcessing
{
    public class Image
    {
        [JsonPropertyName("full")]
        public string Full { get; set; }
    }
}
