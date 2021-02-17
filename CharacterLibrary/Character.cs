﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        private string _name;
        private int _life;

        public int MaxLife { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int Speed { get; set; }
        public string Name
        {
            get { return _name; }
            set { _name = value.Trim(); }
        }//end Name
        public int Life
        {
            get { return _life; }
            set
            {
                _life = value <= MaxLife ? value : MaxLife;
            }//end Set
        }//end Life
        public Character(string name, int life, int maxLife, int hitChance, int block, int speed)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            HitChance = hitChance;
            Block = block;
            Speed = speed;
        }//FQCTOR

        public virtual int CalcBlock()
        {
            return Block;
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public abstract int CalcDamage();
        //because this method is abstract we are forcing the child classes to complete the 
        //functionality by overriding what we build here


    }
}
