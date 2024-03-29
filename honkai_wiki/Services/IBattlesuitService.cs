﻿using honkai_wiki_api.Models;
using Newtonsoft.Json.Linq;

namespace honkai_wiki.Services
{
    public interface IBattlesuitService
    {
        Task<string> GetAsync();
        Task<string> GetAsync(int id);
    }
}
