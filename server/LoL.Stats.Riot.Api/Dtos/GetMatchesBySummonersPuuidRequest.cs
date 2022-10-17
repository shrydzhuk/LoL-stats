namespace LoL.Stats.Riot.Api.Dtos
{
    public class GetMatchesBySummonersPuuidRequest
    {
        public string Puuid { get; set; }

        public int Count { get; set; } = 5;

        internal string GetQueryString()
        {
            return $"?count={Count}";
        }
    }
}
