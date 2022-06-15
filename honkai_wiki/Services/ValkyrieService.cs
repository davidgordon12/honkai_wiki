using System.Net.Http.Json;
using honkai_wiki_api.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace honkai_wiki.Services
{
    public class ValkyrieService : IValkyrieService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://honkaiwiki-api.azurewebsites.net/valkyries";

        public ValkyrieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Valkyrie>> GetValkyriesAsync()
        {
            var contentWithRoot = await _httpClient.GetStringAsync(url);
            var content = JObject.Parse(contentWithRoot)["value"].ToString(Formatting.None);
            return JsonConvert.DeserializeObject<List<Valkyrie>>(content);
        }

        public Task<Valkyrie> GetValkyrieAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
