using honkai_wiki_api.Models;
using Newtonsoft.Json.Linq;

namespace honkai_wiki.Services
{
    public interface IHonkaiService
    {
        Task<string> GetValkyriesAsync();
        Task<string> GetValkyrieAsync(int id);
    }
}
