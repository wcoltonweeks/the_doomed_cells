using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DungeonLibrary
{
    public class Combat
    {
        public static void Attack(Character attacker, Character defender)
        {
            Random diceRoll = new Random();
            int result = diceRoll.Next(1, 101);
            System.Threading.Thread.Sleep(30);//this is going to make the results more random
            if (result <= attacker.CalcHitChance() - defender.CalcBlock())
            {
                int damageDelt = attacker.CalcDamage();
                defender.Life -= damageDelt;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDelt} damage!");
                Console.ResetColor();
            }//end of attacker hit
            else
            {
                Console.WriteLine($"{attacker.Name} missed.");
            }//end else

        }//end attack

        public static void Battle(Player player, Monster monster)
        {
            Random speedRoll = new Random();
            int playerInitiative = speedRoll.Next(1, 11) + player.Speed;
            System.Threading.Thread.Sleep(25);
            int monsterInitiative = speedRoll.Next(1, 11) + monster.Speed;
            Console.WriteLine($"{(playerInitiative >= monsterInitiative ? $"{player.Name}" : $"{monster.Name}")} attacks first!");
            if (playerInitiative >= monsterInitiative)
            {
                Attack(player, monster);
                if (monster.Life > 0)
                {
                    Attack(monster, player);
                }
            }//end if player attacks first
            else
            {
                Attack(monster, player);
                if (player.Life > 0)
                {
                    Attack(player, monster);
                }
            }//end if monster attacks first

        }
    }
}
