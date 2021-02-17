using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player: Character
    {

        
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int life, int maxLife, int hitChance, int block, int speed, Weapon equippedWeapon) : base(name, life, maxLife, hitChance, block, speed)
        {
           
            EquippedWeapon = equippedWeapon;
            
        }//FQCTOR

        public override string ToString()
        {
            return string.Format($"{Name}\nLife: {Life} of {MaxLife}\nHit Chance: {CalcHitChance()}%\nBlock Chance: {Block}%\nEquipped Weapon: {EquippedWeapon}");
        }

        public override int CalcHitChance()
        {
            return HitChance += EquippedWeapon.BonusHitChance;
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }
    }
}
