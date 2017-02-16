using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Store store;
        Inventory inventory;
        Report report;
        Wallet wallet;
        Customer customer;
        Weather weather;
        List<Customer> customers;
        public int numberOfPlayers;
        public int daysToPlay;
        public int currentDay;
        public Game()
        {

            wallet = new Wallet();
            report = new Report();
            inventory = new Inventory();
            store = new Store(inventory);
            report = new Report();
            customer = new Customer();
            weather = new Weather();
            currentDay = 1;
        }
        public void RunGame()
        {
            Welcome();
            AskForRules();
            GetPlayers();
            GetPlayersName();
            ChooseDaysToPlay();
            DisplayMenu();
        }
        public void StartDay()
        {
            DisplayCurrentDay();
            weather.DisplayWeather();
            customer.BuyingCustomers();
            report.DisplayDailyReport(currentDay);
            EndDay();
        }
        public void Welcome()
        {
            Console.WriteLine("\n                               WHAT DO YOU GET WHEN LIFE GIVES YOU LEMONS ??? \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("||||| L E M O N A D E ||||| L E M O N A D E ||||| L E M O N A D E ||||| L E M O N A D E ||||| L E M O N A D E ||||| \n");
            Console.ResetColor();
   
        }
        public void AskForRules()
        {
            Console.WriteLine("WOULD YOU LIKE TO SEE THE RULES?");
            Console.WriteLine("SELECT [1] YES");
            Console.WriteLine("SELECT [2] NO \n");
            string input = Console.ReadLine().ToLower();
            if (input == "1" || input == "y" || input == "yes")
            {
                DisplayRules();
            }
            else if (input == "2" || input == "n" || input == "no")
            {
                Console.WriteLine("OKAY . . . NO RULES FOR YOU! \n  press any key to continue . . . \n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nINVALID INPUT \n");
                AskForRules();
            }
        }
        public void DisplayRules()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\nIt's going to be tough to make it in this business!");
            Console.WriteLine("Keep track of your inventory and cash balance then create your recipe and set the price of your lemonade. \nThe weather will have an affect on how many customers stop by. \n");
            Console.WriteLine("It looks like all you have is [20 bucks] to get started with . . . that'll be fine just manage your cash wisely! \n"); Console.ResetColor();
            Console.WriteLine("What are you waiting for????"); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("         $ $ $ $ $ $    G O   M A K E   S O M E   M O N E Y    $ $ $ $ $ $ \n"); Console.ResetColor();
        }
        public void GetPlayers()
        {
            bool chosen = false;
            while (!chosen)
            {
                Console.WriteLine("HOW MANY PLAYERS WOULD LIKE TO PLAY???? [ 1 - 4 ] \n");
                string players = Console.ReadLine();
                switch (players)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        Console.WriteLine("SETTING GAME TO {0} PLAYER(S). \n", players);
                        chosen = true;
                        numberOfPlayers = Convert.ToInt32(players);
                        break;
                    default:
                        Console.WriteLine("INVALID INPUT \n");
                        break;
                }
            }
        }
        public void GetPlayersName()
        {
            Player[] PlayerNames = new Player[numberOfPlayers];
            for (int i = 0; i < numberOfPlayers; i++)
            {
                PlayerNames[i] = new Player();
                Console.WriteLine("Player {0}, what is your name? \n", i + 1);
                PlayerNames[i].Name = Console.ReadLine();
                if (PlayerNames[i].Name.Equals(""))
                {
                    Console.WriteLine("\nINVALID INPUT \n");
                    GetPlayersName();
                }
            }
        }
        public void ChooseDaysToPlay()
        { 
            Console.WriteLine("\nHow many days would you like to play? Please enter a number [ 1 - 10 ] \n");
            try
            {
                daysToPlay = Int32.Parse(Console.ReadLine());
                switch (daysToPlay)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine($"You are set to play {daysToPlay} days! \n");
                        Console.WriteLine("Okay . . . . \nREADY \nSET \nGO! \n");
                        break;
                    default:
                        Console.WriteLine("INVALID INPUT \n");
                        ChooseDaysToPlay();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("INVALID INPUT \n");
                ChooseDaysToPlay();
            }
        }
        public void DisplayMenu()
        {
            while (currentDay <= daysToPlay)
            {
                Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\nPLEASE CHOOSE A MENU OPTION : \n");
                Console.WriteLine("[1] Weather Forcast       [2] Buy Supplies       [3] Create Recipe");
                Console.WriteLine("[4] Set Price             [5] Sales Report       [6] START DAY ");
                Console.WriteLine("[7] SAVE Data             [8] QUIT"); Console.ResetColor();
                string userImput = Console.ReadLine();
                switch (userImput)
                {
                    case "1":
                        weather.RandomizeOvercast();
                        break;
                    case "2":
                        store.BuyFromStore();
                        break;
                    case "3":
                        inventory.DisplayRecipe();
                        break;
                    case "4":
                        inventory.SetPrice();
                        break;
                    case "5":
                        wallet.DisplayWallet();
                        report.DisplayDailyReport(currentDay);
                        break;
                    case "6":
                        StartDay();
                        EndDay();
                        break;
                    case "7":
                        try
                        {
                            Console.WriteLine("We are trying to save your data . . . . . . . . . .");
                        }
                        catch
                        {
                            Console.WriteLine("Oops... There was an error saving your data.");
                            DisplayMenu();
                        }
                        break;
                    case "8":
                        Console.WriteLine("ARE YOU SURE YOU WANT TO QUIT ???  \nSELECT [1] YES \nSELECT [2] NO \n");
                        string input = Console.ReadLine().ToLower();
                        switch (input)
                        {
                            case "1":
                            case "y":
                            case "yes":
                                EndGame();
                                break;
                            case "2":
                            case "n":
                            case "no":
                                Console.WriteLine("Okay . . .   Continue . . .");
                                DisplayMenu();
                                break;
                            default:
                                Console.WriteLine("INVALID INPUT \n");
                                break;
                        }
                        break;
                }
            }
            EndGame();
        }
        public int DisplayCurrentDay()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"\n\n-------------- D A Y {currentDay} ---------");
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
            return currentDay;
        }
        public int AddDay()
        {
            currentDay += 1;
            return currentDay;
        }
        public void EndDay()
        {
            wallet.ResetDailyExpense();
            wallet.ResetDailyProfit();
        }
        public void EndGame()
        {
            Console.WriteLine("Would you like to play again? \n");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y" || userInput == "yes")
            {
                RunGame();
            }
            else if (userInput == "n" || userInput == "no")
            {
                Console.WriteLine("Sorry to see you go . . . no more money making for you . . .");
                Console.ReadKey(); Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("INVALID INPUT \n");
                EndGame();
            }
        }
    }
}
