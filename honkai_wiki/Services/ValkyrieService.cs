using System.Net.Http.Json;
using honkai_wiki_api.Models;
using Newtonsoft.Json;

namespace honkai_wiki.Services
{
    public class ValkyrieService : IValkyrieService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7061/valkyries";

        public ValkyrieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Valkyrie>> GetValkyries()
        {
            var content = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<Valkyrie>>(content);
        }
    }
}
