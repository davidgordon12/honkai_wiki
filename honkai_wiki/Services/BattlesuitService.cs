using System.Net.Http.Json;
using honkai_wiki_api.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace honkai_wiki.Services
{
    public class BattlesuitService : IBattlesuitService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://honkaiwiki-api.azurewebsites.net/battlesuits";

        public BattlesuitService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetAsync()
        {
            var contentWithRoot = await _httpClient.GetStringAsync(url);
            return JObject.Parse(contentWithRoot)["value"].ToString(Formatting.None);
            
        }

        public Task<string> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
