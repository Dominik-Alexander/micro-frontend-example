using System.ComponentModel.DataAnnotations;

namespace Pokeymanz.Models
{
    public class AddPokeymanDto
    {
        public required string Species { get; set; }
        public string? Name { get; set; }
        [MaxLength(2)]
        public required string[] Types { get; set; }
        public required decimal Level { get; set; }
        public required string Ability { get; set; }
        public string? HeldItem { get; set; }
        public required string[] AvailableAttacks { get; set; }
        [MaxLength(4)]
        public required string[] EquippedAttacks { get; set; }
        public required string Nature { get; set; }
        public required string Description { get; set; }
        public required string EggGroup { get; set; }
    }
}
