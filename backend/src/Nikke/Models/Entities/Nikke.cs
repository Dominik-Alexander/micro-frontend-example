namespace Nikke.Models.Entities
{
    public class Nikke
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string WeaponType { get; set; }
        public required string Element { get; set; }
        public required string Rarity { get; set; }
    }
}
