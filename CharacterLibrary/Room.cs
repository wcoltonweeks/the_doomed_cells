using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Room
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public Monster Monster { get; set; }
        public int NorthRoom { get; set; }
        public int SouthRoom { get; set; }
        public int EastRoom { get; set; }
        public int WestRoom { get; set; }
        public bool IsMonsterDead { get; set; }

        public Room(string name, string description, Monster monster, int northRoom, int southRoom, int eastRoom, int westRoom, bool isMonsterDead)
        {
            Name = name;
            Description = description;
            Monster = monster;
            NorthRoom = northRoom;
            SouthRoom = southRoom;
            EastRoom = eastRoom;
            WestRoom = westRoom;
            IsMonsterDead = isMonsterDead;

        }//fqctor

        public Room()
        {

        }


    }
}
