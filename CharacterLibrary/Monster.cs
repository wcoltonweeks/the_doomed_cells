using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        private int _minDamage;
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public bool isAlive { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value <= MaxDamage ? value : MaxDamage;
            }//end set
        }//end MinDamage

        public Monster(string name, int life, int maxLife, int hitChance, int block, int speed, int minDamage, int maxDamage, string desctiption) : base(name, life, maxLife, hitChance, block, speed)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = desctiption;
        }//fqctor


        public override string ToString()
        {
            return string.Format($"{Name}\n{Description}\n {(Life == MaxLife ? "It is uninjured" : Life >= MaxLife / 2 ? "It is wounded." : "It is already gravely wounded. You might as well just finish it off.")}");
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(MinDamage, MaxDamage + 1);
            return damage;
        }
    }
}
