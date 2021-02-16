using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            do
            {









            } while (!proceed);



        }
    }
}
