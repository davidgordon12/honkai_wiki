using honkai_wiki_api.Models;

namespace honkai_wiki.Services
{
    public interface IValkyrieService
    {
        Task<List<Valkyrie>> GetValkyriesAsync();
        Task<Valkyrie> GetValkyrieAsync(int id);
    }
}
