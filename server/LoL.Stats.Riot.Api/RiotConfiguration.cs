namespace LoL.Stats.Riot.Api
{
    public class RiotConfiguration
    {
        private static string apiKey;

        internal static string GetApiKey()
        {
            return apiKey;
        }

        public static void SetApiKey(string newApiKey)
        {
            apiKey = newApiKey;
        }
    }
}
