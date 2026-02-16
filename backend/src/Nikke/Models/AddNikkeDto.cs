namespace Nikke.Models
{
    public class AddNikkeDto
    {
        public required string Name { get; set; }
        public required string WeaponType { get; set; }
        public required string Element { get; set; }
        public required string Rarity { get; set; }
    }
}
