using Microsoft.AspNetCore.Mvc;
using Nikke.Data;
using Nikke.Models;

namespace Nikke.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NikkeController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public NikkeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetNikkeById(Guid id)
        {
            var nikke = dbContext.Nikkes.Find(id);

            if (nikke is null)
            {
                return NotFound();
            }
            return Ok(nikke);
        }

        [HttpGet]
        public IActionResult GetAllNikkes()
        {
            var allNikkes = dbContext.Nikkes.ToList();
            return Ok(allNikkes);
        }

        [HttpPost]
        public IActionResult AddNikke(AddNikkeDto addNikkeDto)
        {
            var nikkeEntity = new Models.Entities.Nikke()
            {
                Id = Guid.NewGuid(),
                Name = addNikkeDto.Name,
                WeaponType = addNikkeDto.WeaponType,
                Element = addNikkeDto.Element,
                Rarity = addNikkeDto.Rarity
            };
            dbContext.Nikkes.Add(nikkeEntity);
            dbContext.SaveChanges();
            return Ok(nikkeEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateNikke(Guid id, UpdateNikkeDto updateNikkeDto)
        {
            var nikkeEntity = dbContext.Nikkes.Find(id);

            if (nikkeEntity is null)
            {
                return NotFound();
            }

            nikkeEntity.Name = updateNikkeDto.Name;
            nikkeEntity.WeaponType = updateNikkeDto.WeaponType;
            nikkeEntity.Element = updateNikkeDto.Element;
            nikkeEntity.Rarity = updateNikkeDto.Rarity;

            dbContext.SaveChanges();

            return Ok(nikkeEntity);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteNikke(Guid id)
        {
            var nikkeEntity = dbContext.Nikkes.Find(id);
            if (nikkeEntity is null)
            {
                return NotFound();
            }
            dbContext.Nikkes.Remove(nikkeEntity);
            dbContext.SaveChanges();
            return Ok(nikkeEntity);
        }
    }
}
