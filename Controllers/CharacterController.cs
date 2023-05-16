using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "Boba" }
        };
    private readonly ICharacterService _characterService;

    public CharacterController(ICharacterService characterService)
        {
      _characterService = characterService;
    }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Character>>> Get() 
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Character>> GetSingle(int Id) 
        {
            return Ok(await _characterService.GetCharacterById(Id));
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}

