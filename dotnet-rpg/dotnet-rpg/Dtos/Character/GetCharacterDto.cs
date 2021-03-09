using dotnet_rpg.Models;

namespace dotnet_rpg.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 05;
        public int Defense { get; set; } = 08;
        public int Inteligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Shaman;
    }
}