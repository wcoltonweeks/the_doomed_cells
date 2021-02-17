using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DungeonLibrary
{
    public class Weapon
    {
        private int _minDamage;

        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int BonusHitChance { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value <= MaxDamage ? value : MaxDamage;
            }//end set
        }//end MinDamage

        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance)
        {
            MaxDamage = maxDamage;
            Name = name;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
        }//FQCTOR

        public override string ToString()
        {
            return string.Format($"{Name}\n{MinDamage} to {MaxDamage} damege\nHit Modifier: {BonusHitChance:p1}");
        }//end ToString()


    }
}
