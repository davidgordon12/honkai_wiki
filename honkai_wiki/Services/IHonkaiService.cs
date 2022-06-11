using honkai_wiki_api.Models;

namespace honkai_wiki.Services
{
    public interface IHonkaiService
    {
        Task<List<Valkyrie>> GetValkyries();
        Task<Valkyrie> GetValkyrie(int id);
    }
}
