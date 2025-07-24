using Microsoft.EntityFrameworkCore;
using RickAndMorty.Data;
using RickAndMorty.Model;
using System.Text.Json;

namespace RickAndMortyApi.Services;

public class CharacterService
{
    private readonly HttpClient _httpClient;
    private readonly ApplicationDbContext _dbContext;

    public CharacterService(HttpClient httpClient, ApplicationDbContext dbContext)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://rickandmortyapi.com/api/");
        _dbContext = dbContext;
    }

    public async Task<List<Character>> GetCharactersByName(string name)
    {
        var response = await _httpClient.GetAsync($"character/?name={Uri.EscapeDataString(name)}");
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(json);
        var results = doc.RootElement.GetProperty("results");
        var characters = new List<Character>();

        foreach (var item in results.EnumerateArray())
        {
            characters.Add(new Character
            {
                Id = Guid.NewGuid().ToString(),
                CharacterId = item.GetProperty("id").GetInt32(),
                Name = item.GetProperty("name").GetString(),
                Status = item.GetProperty("status").GetString(),
                Species = item.GetProperty("species").GetString(),
                ImageUrl = item.GetProperty("image").GetString(),
                Note = null
            });

            var firstCharacter = characters.FirstOrDefault();

            if (firstCharacter != null)
            {
                var exists = await _dbContext.Character.AnyAsync(c => c.Id == firstCharacter.Id);
                if (!exists)
                {
                    _dbContext.Character.Add(firstCharacter);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }

        return characters;
    }

}
