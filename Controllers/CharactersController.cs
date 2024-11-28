using Microsoft.AspNetCore.Mvc;

namespace undertale_api;
[ApiController]
[Route("api/characters")]

public class _CharactersController : ControllerBase
{
    private readonly AppDbContext _context;

    private static List<Characters> characters = new List<Characters> {
        new Characters {Id =, Stage ="", Name = "", HP =, Type = "", Info = "", AbilityOne = "", AbilityTwo = "", DamageOne =, DamageTwo =, Weak = "", Resistance = "", ExtraInfo = "", Retreat = "" },
    };

    public _CharactersController(AppDbContext context)
    {
        _context = context;
        if (!_context.Characters.Any())
        {
            _context.Characters.AddRange(characters);
            _context.SaveChanges();
        }
    }


    // create the GET endpoint
    [HttpGet]
    public Action<IEnumerable<Characters>> GetCharacters()
    {
        return _context.Characters();
    }
}