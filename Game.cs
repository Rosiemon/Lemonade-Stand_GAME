using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player player;
        Store store;
        Inventory inventory;
        Report report;
        List<Customer> customers;
        Customer customer = new Customer();
        public int numberOfPlayers;
        public int daysToPlay;
        public int currentDay;

        public Game()
        {
            player = new Player();
            inventory = new Inventory();
            report = new Report();
            Customer customer = new Customer();
            currentDay = 1;
        }
        public void RunGame()
        {
            Welcome();
            GetPlayerName();
            ChooseDays();
            DisplayMenu();
        }
        public void StartDay() // everything in here needs to be in a loop for as many days as they choose
        {
            while (currentDay <= daysToPlay)
            {
                DisplayCurrentDay();
                inventory.DisplayInventory();
                store.BuyFromStore();
                inventory.DisplayRecipe();
                inventory.SetPrice();
                customer.RandomizeCustomers();
                DisplayCustomers();
                report.DisplayDailyReport(currentDay);
            }
            EndGame();
        }
        public void Welcome()
        {
            Console.WriteLine("                     What do you get when life throws you lemons? \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                               |||||| LEMONADE |||||| \n");
            Console.ResetColor();
            Console.ReadLine();
        }
        public void GetPlayerName()
        {
            Console.WriteLine("Please enter your name . . .");
            string players = Console.ReadLine();
        }
        public void ChooseDays()
        {
            Console.WriteLine("How many days would you like to play? Please enter [1-10]");
            string numberOfDaysToPlay = Console.ReadLine();
            switch (numberOfDaysToPlay)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    Console.WriteLine("You are set to play {0} days!", numberOfDaysToPlay);
                    daysToPlay = Convert.ToInt32(numberOfDaysToPlay);
                    break;
                default:
                    Console.WriteLine("INVALID INPUT \nPlease enter a number between [1-10]");
                    ChooseDays();
                    break;
            }
        }
        public void DisplayMenu() //I dont think I need to keep number 7 for the first display before they choose start game
        {
            Console.WriteLine("Please choose a menu option : \n"); 
            Console.WriteLine("Select [1] to display the rules");
            Console.WriteLine("Select [2] to start the game");
            Console.WriteLine("Select [3] to buy from the store");
            Console.WriteLine("Select [4] to view your inventory");
            Console.WriteLine("Select [5] to create your recipe");
            Console.WriteLine("Select [6] to change the price of your lemonade");
            Console.WriteLine("Select [7] to end the game");
            string userImput = Console.ReadLine();

            if (userImput == "1")
            {
                Rules rules = new Rules();
                rules.ShowRules();
            }
            else if (userImput == "2")
            {
                StartDay();
            }
            else if (userImput == "3")
            {
                Store store = new Store();
                store.BuyFromStore();
            }
            else if (userImput == "4")
            {
                Inventory inventory = new Inventory();
                inventory.DisplayInventory();
            }
            else if (userImput == "5")
            {
                Inventory inventory = new Inventory();
                inventory.DisplayRecipe();
            }
            else if (userImput == "6")
            {
                Inventory inventory = new Inventory();
                inventory.SetPrice();
            }
            else if (userImput == "7")
            {
                EndGame();
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
                DisplayMenu();
            }
        }
        public int AddDay()
        {
            currentDay += 1;
            return currentDay;
        }
        public int DisplayCurrentDay()
        {
            return currentDay;
        }
        public Customer MakeCustomer()
        {
            Customer customer = new Customer();
            customer.RandomizeCustomers();
            return customer;
        }
        public void DisplayCustomers()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Cusotmer Name: {0} Thirst: {1} Cash: {2}", customer.GetCustomerName(), customer.GetCustomerThirst(), customer.GetCustomerMoney());
            }
        }
        public void EndGame()
        {
            Console.WriteLine("Would you like to play again?");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y" || userInput == "yes")
            {
                RunGame();
            }
            else if (userInput == "n" || userInput == "no")
            {
                Console.WriteLine("GOODBYE. HAVE A NICE DAY!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("INVALID INPUT \n");
                EndGame();
            }
        }
    }
}
