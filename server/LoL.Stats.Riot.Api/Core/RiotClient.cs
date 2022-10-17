using LoL.Stats.Riot.Api.Exceptions;
using LoL.Stats.Riot.Api.Utils;
using System.Text.Json;

namespace LoL.Stats.Riot.Api.Core
{
    internal class RiotClient
    {
        private readonly string apiKey;

        public RiotClient()
        {
            apiKey = RiotConfiguration.GetApiKey();
            if (string.IsNullOrEmpty(apiKey))
                throw new ArgumentNullException("apiKey");
        }

        internal async Task<T> GetAsync<T>(string url)
        {
            try
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Add(RiotHeaderContants.API_KEY_HEADER_NAME, apiKey);

                var content = await client.GetStringAsync(url);
                return JsonSerializer.Deserialize<T>(content);
            }
            catch (Exception ex)
            {
                throw new RiotException(ex.Message, ex);
            }
        }
    }
}
