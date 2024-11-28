using Microsoft.AspNetCore.Mvc;

namespace undertale_api;
[ApiController]
[Route("api/characters")]

public class _CharactersController : ControllerBase
{


    private static List<Characters> characters = new List<Characters> {
        new Characters {Id =, Stage ="", Name = "", HP =, Type = "", Info = "", AbilityOne = "", AbilityTwo = "", DamageOne =, DamageTwo =, Weak = "", Resistance = "", ExtraInfo = "", Retreat = "" },
    };

    // create the GET endpoint
    [HttpGet]
    public Action<IEnumerable<Characters>> GetCharacters()
    {
        return _context.Characters();
    }
}