using System.Collections.Generic;
using dotnet_rpg.CharacterServ;

namespace dotnet_rpg.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 05;
        public int Defense { get; set; } = 08;
        public int Inteligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Shaman;
        public User User { get; set; }
        public Weapon Weapon { get; set; }
        public List<CharacterSkill> CharacterSkills { get; set; }
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}