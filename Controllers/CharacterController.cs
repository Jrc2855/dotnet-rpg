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

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get() 
        {
            return Ok(characters);
        }

        [HttpGet("{Id}")]
        public ActionResult<Character> GetSingle(int Id) 
        {
            return Ok(characters.FirstOrDefault(c => c.Id == Id));
        }
    }
}