using Microsoft.AspNetCore.Mvc;

namespace undertale_api;
[ApiController]
[Route("api/characters")]

public class _CharactersController : ControllerBase
{
    private readonly AppDbContext _context;

    private static List<Characters> characters = new List<Characters> {
        //template
         /*new Characters {Id = , Stage = "", Name = "", HP = , LV = , AT = , DF = , EXP = , Type = , Info = "", Abilities = "{}", Attacks = "{}", Affinity = "", Resistance = "", Retreat = "", ExtraInfo = ""},*/
        // Main Characters
        new Characters {Id = 1, Stage = "Pacifist", Name = "Frisk", HP = "20", LV = "LV 1", AT = "0", DF = "0", EXP = "0", Type = "Normal", Info = "A human child who has fallen down into the undeground.", Abilities = {"SAVE", "TALK", "SPARE", "FIGHT"}, Affinity = "Hot dogs, pie and striped sweaters", Resistance = "", Retreat = "", ExtraInfo = "Encountering this card fills you with DETERMINATION."},

        new Characters {Id = 2, Stage = "Neutral", Name = "Frisk", HP = "20-92", LV = "LV 1 - LV 19", AT = "0-36", DF = "0-4", EXP = "50000", Type = "Normal", Info = "A human child who has fallen down into the undeground.", Abilities = {"SAVE", "TALK", "SPARE", "FIGHT"}, Affinity = "Hot dogs, pie and striped sweaters", Resistance = "", Retreat = "", ExtraInfo = "Encountering this card fills you with DETERMINATION."},

        new Characters {Id = 3, Stage = "Genocide", Name = "Frisk", HP = "99", LV = "LV 20", AT = "38", DF = "4", EXP = "99999", Type = "Normal", Info = "A human child who has fallen down into the undeground.", Abilities = {"SAVE", "TALK", "SPARE", "FIGHT"}, Affinity = "", Resistance = "", Retreat = "", ExtraInfo = "Encountering this card fills me with DETERMINATION."},

        new Characters {Id = 4, Stage = "Genocide", Name = "Chara", HP = "??", LV = "??", AT = "??", DF = "??", EXP = "??", Type = "??", Info = "The first fallen human.", Abilities = {"SOUL control", "Destroy the world", "SPARE", "FIGHT"}, Affinity = "The destruction of the world", Resistance = "", Retreat = "", ExtraInfo = "DETERMINATION."},

        new Characters {Id = 5, Stage = "Pacifist", Name = "sans.", HP = "1", AT = "1", DF = "1", Type = "Psychic", Info = "The easiest enemy. Can only deal 1 damage",  Weak = "", Resistance = "", ExtraInfo = "", Retreat = "" },

        new Characters {Id = 3, Stage ="Pacifist", Name = "Papyrus", HP = 680, AT = 20, DF = 20, EXP = 3, Type = "", Info = "He likes to say: 'Nyeh heh heh!'", Weak = "Flirting", Resistance = "", ExtraInfo = "Loves puzzles", Retreat = "" },
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
        return CreatedAtAction(nameof(Post), new { id = _characters.Id, stage = _characters.Stage, name = _characters.Name, hp = _characters.HP, type = _characters.Type, info = _characters.Info, weak = _characters.Weak, resistance = _characters.Resistance, extrainfo = _characters.ExtraInfo, retreat = _characters.Retreat }, _characters);
    }

}