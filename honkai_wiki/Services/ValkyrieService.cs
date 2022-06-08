using System.Net.Http.Json;
using honkai_wiki_api.Models;

namespace honkai_wiki.Services
{
    public class ValkyrieService : IValkyrieService
    {
        private readonly HttpClient _httpClient;

        public ValkyrieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Valkyrie>> GetValkyries()
        {
            return await _httpClient.GetFromJsonAsync<List<Valkyrie>>("https://localhost:7061/valkyries");
        }
    }
}
