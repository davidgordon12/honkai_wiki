using System.Net.Http.Json;
using honkai_wiki_api.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace honkai_wiki.Services
{
    public class ValkyrieService : IHonkaiService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7061/valkyries";

        public ValkyrieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Valkyrie>> GetValkyries()
        {
            var contentWithRoot = await _httpClient.GetStringAsync(url);
            var content = JObject.Parse(contentWithRoot)["value"].ToString(Formatting.None);
            return JsonConvert.DeserializeObject<List<Valkyrie>>(content);
        }

        public Task<Valkyrie> GetValkyrie(int id)
        {
            throw new NotImplementedException();
        }
    }
}
