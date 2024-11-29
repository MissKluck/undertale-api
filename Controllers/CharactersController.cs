using Microsoft.AspNetCore.Mvc;

namespace undertale_api;
[ApiController]
[Route("api/characters")]

public class _CharactersController : ControllerBase
{
    private readonly AppDbContext _context;

    private static List<Characters> characters = new List<Characters> {
        new Characters {Id = 1, Stage = "Pacifist", Name = "Frisk", HP = 20, LV = "LV 1", AT = 0, DF = 0, EXP = 0, Type = "Normal", Info = "A human child who has fallen down into the undeground.", AbilityOne = "TALK", AbilityTwo = "SPARE", DamageOne =, DamageTwo =, Weak = "", Resistance = "", ExtraInfo = "", Retreat = "" },
        new Characters {Id = 2, Stage = "Pacifist", Name = "sans.", HP = 1, AT = 1, DF = 1, Type = "Psychic", Info = "The easiest enemy. Can only deal 1 damage", AbilityOne = "", AbilityTwo = "", DamageOne =, DamageTwo =, Weak = "", Resistance = "", ExtraInfo = "", Retreat = "" },
        new Characters {Id = 3, Stage ="Pacifist", Name = "Papyrus", HP = 680, AT = 20, DF = 20, EXP =, Type = "", Info = "He likes to say: 'Nyeh heh heh!'", AbilityOne = "", AbilityTwo = "", DamageOne =, DamageTwo =, Weak = "", Resistance = "", ExtraInfo = "", Retreat = "" },
        new Characters {Id =, Stage ="", Name = "", HP =, AT =, DF =, EXP =, Type = "", Info = "", AbilityOne = "", AbilityTwo = "", DamageOne =, DamageTwo =, Weak = "", Resistance = "", ExtraInfo = "", Retreat = "" },
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
    public IEnumerable<Characters> GetCharacters()
    {
        return _context.Characters.ToList();
    }

    // create the POST endpoint
    [HttpPost]
    public IActionResult Post([FromBody] Characters _characters)
    {
        if (characters == null)
        {
            return BadRequest("Client error occured!");
        }
        _context.Add(_characters);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Post), new { id = _characters.Id, stage = _characters.Stage, name = _characters.Name, hp = _characters.HP, type = _characters.Type, info = _characters.Info, abilityone = _characters.AbilityOne, abilitytwo = _characters.AbilityTwo, damageone = _characters.DamageOne, damagetwo = _characters.DamageTwo, weak = _characters.Weak, resistance = _characters.Resistance, extrainfo = _characters.ExtraInfo, retreat = _characters.Retreat }, _characters);
    }

}