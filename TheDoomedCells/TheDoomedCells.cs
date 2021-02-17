using DungeonLibrary;
using System;


namespace TheDoomedCells
{
    class TheDoomedCells
    {
        static void Main(string[] args)
        {
            #region TitleScreen
            bool proceed = false;
            do
            {
                Console.WriteLine(@"

▄▄▄█████▓ ██░ ██ ▓█████    ▓█████▄  ▒█████   ▒█████   ███▄ ▄███▓▓█████ ▓█████▄     ▄████▄  ▓█████  ██▓     ██▓      ██████ 
▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▒██▀ ██▌▒██▒  ██▒▒██▒  ██▒▓██▒▀█▀ ██▒▓█   ▀ ▒██▀ ██▌   ▒██▀ ▀█  ▓█   ▀ ▓██▒    ▓██▒    ▒██    ▒ 
▒ ▓██░ ▒░▒██▀▀██░▒███      ░██   █▌▒██░  ██▒▒██░  ██▒▓██    ▓██░▒███   ░██   █▌   ▒▓█    ▄ ▒███   ▒██░    ▒██░    ░ ▓██▄   
░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ░▓█▄   ▌▒██   ██░▒██   ██░▒██    ▒██ ▒▓█  ▄ ░▓█▄   ▌   ▒▓▓▄ ▄██▒▒▓█  ▄ ▒██░    ▒██░      ▒   ██▒
  ▒██▒ ░ ░▓█▒░██▓░▒████▒   ░▒████▓ ░ ████▓▒░░ ████▓▒░▒██▒   ░██▒░▒████▒░▒████▓    ▒ ▓███▀ ░░▒████▒░██████▒░██████▒▒██████▒▒
  ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░    ▒▒▓  ▒ ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░   ░  ░░░ ▒░ ░ ▒▒▓  ▒    ░ ░▒ ▒  ░░░ ▒░ ░░ ▒░▓  ░░ ▒░▓  ░▒ ▒▓▒ ▒ ░
    ░     ▒ ░▒░ ░ ░ ░  ░    ░ ▒  ▒   ░ ▒ ▒░   ░ ▒ ▒░ ░  ░      ░ ░ ░  ░ ░ ▒  ▒      ░  ▒    ░ ░  ░░ ░ ▒  ░░ ░ ▒  ░░ ░▒  ░ ░
  ░       ░  ░░ ░   ░       ░ ░  ░ ░ ░ ░ ▒  ░ ░ ░ ▒  ░      ░      ░    ░ ░  ░    ░           ░     ░ ░     ░ ░   ░  ░  ░  
          ░  ░  ░   ░  ░      ░        ░ ░      ░ ░         ░      ░  ░   ░       ░ ░         ░  ░    ░  ░    ░  ░      ░  
                            ░                                           ░         ░                                        
                                 ]=I==II==I=[
                                   \\__||__//                 ]=I==II==I=[
              ]=I==II==I=[          |.. ` *|                   \\__||__//               
               \\__||__//           |. /\ #|                    |-_ []#|
                | []   |            |  ## *|                    |      |           
                |    ..|            | . , #|                  ]=I==II==I=[      
___   ____  ___ |   .. |         __ |..__.*| __                \\__||__//        A Console Application
] I---I  I--I [ |..    |        |  ||_|  |_|| |                 |    _*|                  by:
]_____________[ | .. []|         \--\-|-|--/-//                 |   _ #|              Colton Weeks
 \_\| |_| |/_/  |_   _ | _   _   _|      ' *|                   |`    *|                
  |  .     |'-'-` '-` '-` '-` '-` | []     #|-|--|-_-_-_-_ _ _ _|_'   #|         
  |     '  |=-=-=-=-=-=-=-=-=-=-=-|      []*|-----________` ` `   ]   *|          
  |  ` ` []|      _-_-_-_-_  '    |-       #|      ,    ' ```````['  _#|
  | '  `  '|   [] | | | | |  []`  |  []    *|   `          . `   |'  I*|
  |      - |    ` | | | | | `     | ;  '   #|     .  |        '  |    #|
 /_'_-_-___-\__,__|_|_|_|_|_______|   `  , *|    _______+___,__,-/._.._.\
             _,--'    __,-'      /,_,_v_Y_,_v\\-'

|)   _  _ _  [~,_|- _     |-     _  ,_|-.,_   _  
| |`(/__\_\  [_|||_(/_|`  |_()  (_()|||_|||L|(/_.
");
                ConsoleKey titleKey = Console.ReadKey().Key;
                switch (titleKey)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        proceed = true;
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine(@"
   _   _   _                 _   _   _
  | |_| |_| |   _   _   _   | |_| |_| |
   \   _   /   | |_| |_| |   \   _   /
    | | | |     \       /     | | | |
    | |_| |______|     |______| |_| |
    |              ___              |
    |  _    _    (     )    _    _  |
    | | |  |_|  (       )  |_|  | | |
    | |_|       |       |       |_| |
   /            |_______|            \
  |___________________________________|

|~~|~|_  ,_|           [`        |    .,_  ~|
<  | ||(||||<  \/()L|  | ()|`  |)|(|\/|||(| >
|_             /               |    /    _|_|
");
                        Console.ReadLine();//stops the console on the exit screen. if the user chooses to press enter they will be taken back to the tite screen.

                        break;
                    default:
                        Console.WriteLine($"{titleKey} is not a valid choice...");
                        break;
                }

            } while (!proceed);
            #endregion
            proceed = true;

            #region MainContent

            
            string playerName = "";

            Weapon ironSword = new Weapon("Iron Sword", 10, 25, 10);


            Console.Title = "Welcome to the Doomed Cells!";
            Console.Write("Welcome, Enter your name: ");
            playerName = Console.ReadLine();
            Console.Clear();


            Player player = new Player(playerName, 100, 100, 80, 20, 20, ironSword);

            Console.WriteLine($"Welcome, {playerName}! Your journey begins...\nYou are a lonely adventurer. You have been wandering the wilderness for months in search of an ancient temple. you have fought through countless dangers but you've still managed to pull through.");
            System.Threading.Thread.Sleep(8000);
            Console.WriteLine("As you're walking through the woods, you come to the top of a large hill. As you gase from the top of the hill, you see a clearing in the distance, containing an ancient structure... Could you have found what you've been looking for?");
            System.Threading.Thread.Sleep(8000);
            Console.WriteLine("You approach the structure. As you get closer, you grow more and more uneasy. You shouldn't be here. Yet, you proceed forward with your investigation of the fortress.");
            System.Threading.Thread.Sleep(8000);
            Console.WriteLine("You come accrosss a large iron door on the south side of the building that seems to be the enterance to the ancient fortress. Next to the door stands an old man. \"Turn back!\" the old man exclaims, \"It is my duty to make sure nobody enters this fortress, for it is cursed. All the residents of this fortress are Doomed to guard these forsaken halls for all of eternity. This cursed place has been guiding travelers here who have all refused to head my words of advice, only to never be seen again.\" ");
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Despite the old man suggesting you turn back, You follow your instincts and proceed to open the iron door. \"If you enter, you will never return.\" says the old man. However, You ignore his comment and continue through The old rusted door. \"So be it..\"");
            System.Threading.Thread.Sleep(15000);
            Console.Clear();


            #endregion

            bool exit = false;



            Monster fallenPrisoner = new Monster("Fallen Prisoner", 20, 20, 50, 0, 10, 8, 15, "There is a very pungent smell in the room. You see a fallen prisoner lying in the Middle of the room. The smell becomes mofe intense as he starts to move. Your presence is unwelcome.\n");
            Monster guard = new Monster("Doomed Guard", 25, 25, 40, 10, 10, 8, 15, "You see a guard standing before you, still and unmoving. His armor is old and rusted. He looks like he's kept his post until the very end of his days. You attempt to move his cold body out of the way, when he suddenly awakes. His days havent reached their end yet.\n");





            Room entry = new Room();
            entry.Name = "The Doomed Cells";
            entry.Description = "This Forgotton prison seems to have been abandoned for a long time. Theres ivy growing all over the ancient stone walls. As the giant iron door shuts loudly behind you, the room you have entered becomes pitch black. Suddenly, the torches lining the walls of this chamber ignite, lighting up the ancient dungeon. You come to a realization that you are not alone...\n";
            entry.Monster = guard;
            entry.NorthRoom = 1;
            entry.IsMonsterDead = false;

            Room sCorr = new Room();
            sCorr.Name = "Cell Block 1";
            sCorr.Description = "description";
            sCorr.Monster = fallenPrisoner;
            sCorr.WestRoom = 2;
            sCorr.EastRoom = 3;
            sCorr.SouthRoom = 0;
            sCorr.IsMonsterDead = false;


            Room swTower = new Room();


            Room[] dungeon = new Room[] {
                    entry, sCorr, swTower
            };



            int roomIndex = 0;


            do
            {

                Room currentRoom = dungeon[roomIndex];

                Console.WriteLine($"You have entered the {currentRoom.Name}. {currentRoom.Description}.");

                do
                {
                    Console.WriteLine($"{currentRoom.Monster.Description}\n{currentRoom.Monster.Name}");
                    Console.WriteLine("Choose an action:\n" +
                    "A)ttack\n" +
                    "F)lee\n" +
                    "P)layer Stats\n" +
                    "M)onster Stats\n" +
                    "Esc) Exit");
                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Combat.Battle(player, currentRoom.Monster);
                            if (currentRoom.Monster.Life < 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{currentRoom.Monster.Name} has fallen. You are victorious");
                                Console.ResetColor();
                                currentRoom.IsMonsterDead = true;

                            }
                            break;
                        case ConsoleKey.F:
                            Console.WriteLine("RUN AWAY!");
                            Combat.Attack(currentRoom.Monster, player);

                            break;
                        case ConsoleKey.P:
                            Console.WriteLine(player);
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine(currentRoom.Monster);
                            break;
                        case ConsoleKey.Escape:
                            Console.WriteLine("Exiting game");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Please choose wisely. Your life depends on it!");
                            break;
                    }
                    if (player.Life < 1)
                    {
                        Console.WriteLine($"You have been slain by the {currentRoom.Monster.Name}");
                        exit = true;
                    }
                } while (currentRoom.IsMonsterDead == false);

                Console.WriteLine("There are 4 directions you can go\n" +
                                    "N)orth\n" +
                                    "S)outh\n" +
                                    "E)ast\n" +
                                    "W)est");
                ConsoleKey direction = Console.ReadKey().Key;
                Console.Clear();
                switch (direction)
                {
                    case ConsoleKey.N:
                        roomIndex = currentRoom.NorthRoom;
                        break;
                    case ConsoleKey.S:
                        roomIndex = currentRoom.SouthRoom;
                        break;
                    case ConsoleKey.E:
                        roomIndex = currentRoom.EastRoom;
                        break;
                    case ConsoleKey.W:
                        roomIndex = currentRoom.WestRoom;
                        break;
                    default:
                        Console.WriteLine("You examine the wall... There's Nothing past here");
                        break;
                }

            } while (!exit);

        }
    }
}





