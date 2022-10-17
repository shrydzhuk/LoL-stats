namespace LoL.Stats.Riot.Api.Utils
{
    internal class Urls
    {
        private static string BaseUrlNa1
        {
            get { return "https://na1.api.riotgames.com"; }
        }

        private static string BaseUrlAmericas
        {
            get { return "https://americas.api.riotgames.com"; }
        }

        public static string GetSummonerByNameUrl
        {
            get { return $"{BaseUrlNa1}/lol/summoner/v4/summoners/by-name" + "/{0}"; }
        }

        public static string GetMatchesBySummonerPuuidUrl
        {
            get { return $"{BaseUrlAmericas}/lol/match/v5/matches/by-puuid" + "/{0}/ids"; }
        }

        public static string GetMatchByIdUrl
        {
            get { return $"{BaseUrlAmericas}/lol/match/v5/matches" + "/{0}"; }
        }
    }
}
