using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Rules
    {
        public void ShowRules()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nIt's going to be tough to make it in this business!");
            Console.WriteLine("You'll need to keep track of your inventory and determine the price of your lemonade \nkeeping in mind the weather which can affect how many customers stop by.");
            Console.WriteLine("You are going to start the business with [20 bucks] and [No Inventory] so the first thing \nyou need to do is buy your supplies from the store. Once you have done that you'll");
            Console.WriteLine(" need to make your recipe and set the price for your lemonade to start making some CASH!!! \n");
            Console.WriteLine("What are you waiting for?         . . . LET'S GO MAKE SOME  $$ MONNEEEYYY $$ \n");
            Console.ResetColor();
        Game game = new Game();
        game.DisplayMenu();
        }
    }
}