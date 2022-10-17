namespace LoL.Stats.Riot.Api.Utils
{
    internal class Urls
    {
        private static string BaseUrlNa1
        {
            get { return "https://na1.api.riotgames.com"; }
        }

        public static string GetSummonerByNameUrl
        {
            get { return $"{BaseUrlNa1}/lol/summoner/v4/summoners/by-name" + "/{0}"; }
        }
    }
}
