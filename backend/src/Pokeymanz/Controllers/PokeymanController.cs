using Microsoft.AspNetCore.Mvc;
using Pokeymanz.Data;
using Pokeymanz.Models;
using Pokeymanz.Models.Entities;

namespace Pokeymanz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokeymanController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public PokeymanController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetPokeymanById(Guid id)
        {
            var pokeyman = dbContext.Pokeymanz.Find(id);
            
            if (pokeyman is null)
            {
                return NotFound();
            }
            return Ok(pokeyman);
        }

        [HttpGet]
        public IActionResult GetAllPokeymanz()
        {
            var allPokeymanz = dbContext.Pokeymanz.ToList();

            return Ok(allPokeymanz);
        }

        [HttpPost]
        public IActionResult AddPokeyman(AddPokeymanDto addPokeymanDto)
        {
            var pokeymanEntity = new Pokeyman()
            {
                Id = Guid.NewGuid(),
                Species = addPokeymanDto.Species,
                Name = addPokeymanDto.Name,
                Types = addPokeymanDto.Types,
                Level = addPokeymanDto.Level,
                Ability = addPokeymanDto.Ability,
                HeldItem = addPokeymanDto.HeldItem,
                AvailableAttacks = addPokeymanDto.AvailableAttacks,
                EquippedAttacks = addPokeymanDto.EquippedAttacks,
                Nature = addPokeymanDto.Nature,
                Description = addPokeymanDto.Description,
                EggGroup = addPokeymanDto.EggGroup
            };

            dbContext.Pokeymanz.Add(pokeymanEntity);
            dbContext.SaveChanges();

            return Ok(pokeymanEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdatePokeyman(Guid id, UpdatePokeymanDto updatePokeymanDto)
        {
            var pokeyman = dbContext.Pokeymanz.Find(id);

            if (pokeyman == null)
            {
                   return NotFound();
            }

            pokeyman.Species = updatePokeymanDto.Species;
            pokeyman.Name = updatePokeymanDto.Name;
            pokeyman.Types = updatePokeymanDto.Types;
            pokeyman.Level = updatePokeymanDto.Level;
            pokeyman.Ability = updatePokeymanDto.Ability;
            pokeyman.HeldItem = updatePokeymanDto.HeldItem;
            pokeyman.AvailableAttacks = updatePokeymanDto.AvailableAttacks;
            pokeyman.EquippedAttacks = updatePokeymanDto.EquippedAttacks;
            pokeyman.Nature = updatePokeymanDto.Nature;
            pokeyman.Description = updatePokeymanDto.Description;
            pokeyman.EggGroup = updatePokeymanDto.EggGroup;

            dbContext.SaveChanges();

            return Ok(pokeyman);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeletePokeyman(Guid id)
        {
            var pokeyman = dbContext.Pokeymanz.Find(id);

            if (pokeyman == null)
            {
                return NotFound();
            }

            dbContext.Pokeymanz.Remove(pokeyman);
            dbContext.SaveChanges();

            return Ok();
        }
    }
}
