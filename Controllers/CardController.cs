using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/cards")]
public class CardController : ControllerBase
{
    [HttpGet("{name}")]
    public IActionResult GetCard(string name)
    {
        var card = new CardModel
        {
            Name = "sans",
            Stage = "Pacifist",
            HP = 1,
            AT = 1,
            DF = 1,
            Type = "Psychic",
            ImageUrl = "file:///Users/Sigrid/Pictures/Sans_overworld.webp",
            Abilities = new List<string> { "Dodge", "Gaster Blaster" },
            Affinities = new List<string> { "Bad puns", "Annoying Papyrus", "Not working" },
            Info = "The easiest enemy. Can only deal 1 damage",
            ExtraInfo = "heh"
        };
        return Ok(card);
    }
}