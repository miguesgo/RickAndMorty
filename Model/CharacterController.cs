using Microsoft.AspNetCore.Mvc;
using RickAndMorty.Model;
using RickAndMortyApi.Services;

namespace RickAndMortyApi.Controllers;

[ApiController]
[Route("api/character")]
public class CharacterController : ControllerBase
{
    private readonly CharacterService _characterService;

    public CharacterController(CharacterService characterService)
    {
        _characterService = characterService;
    }

    [HttpGet]
    public async Task<ActionResult<Character>> GetCharacterByName([FromQuery] string name)
    {
        var characters = await _characterService.GetCharactersByName(name);
        var character = characters.FirstOrDefault();

        if (character == null)
        {
            return NotFound($"No se encontró ningún personaje con el nombre: {name}");
        }

        return Ok(character);
    }

}
