using System.Text.Json.Serialization;

namespace LoL.Stats.Riot.Api.Models.Matches
{
    public class MatchInfo
    {
        [JsonPropertyName("gameCreation")]
        public long GameCreation { get; set; }

        [JsonPropertyName("gameDuration")]
        public int GameDuration { get; set; }

        [JsonPropertyName("participants")]
        public List<Participant> Participants { get; set; }
    }
}
