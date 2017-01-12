using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        Wallet wallet;
        Player player;
        public double pricePerLemon;
        public double pricePerSugar;
        public double pricePerIce;
        public double pricePerCup;
        public int boughtLemons;
        public int boughtSugar;
        public int boughtIce;
        public int boughtCups;
        public Store()
        {
            wallet = new Wallet();
            player = new Player();
            pricePerLemon = 0.20;
            pricePerSugar = 0.10;
            pricePerIce = 0.05;
            pricePerCup = 0.10;
        }
        public void BuyFromStore()
        {
            Wallet wallet = new Wallet();
            wallet.DisplayWallet();
            DisplayItemPrice();
            BuyItems();
        }
        public void DisplayItemPrice()
        {
            Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Price for each item :");
            Console.WriteLine("Lemon : {0:0.00}", pricePerLemon);
            Console.WriteLine("Sugar : {0:0.00}", pricePerSugar);
            Console.WriteLine("Ice   : {0:0.00}", pricePerIce);
            Console.WriteLine("Cup   : {0:0.00}", pricePerCup); Console.ResetColor();
        }
        public void BuyItems()  
        {
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\nWhat item do you want to buy? \n");
            Console.WriteLine("Select [1] Buy Lemons");
            Console.WriteLine("Select [2] Buy Sugar Cubes");
            Console.WriteLine("Select [3] Buy Ice Cubes");
            Console.WriteLine("Select [4] Buy Cups");
            Console.WriteLine("Select [5] EXIT"); Console.ResetColor();
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1": 
                    BuyLemon(wallet.moneyInWallet);
                    BuyItems();
                    break;
                case "2":
                    BuySugar(wallet.moneyInWallet);
                    BuyItems();
                    break;
                case "3":
                    BuyIce(wallet.moneyInWallet);
                    BuyItems();
                    break;
                case "4":
                    BuyCups(wallet.moneyInWallet);
                    BuyItems();
                    break;
                case "5":
                    Console.WriteLine("press any key to continue . . .");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("INVALID INPUT \n");
                    BuyItems();
                    break;
            }
        }
        public void BuyLemon(double moneyInWallet)
        {
            Console.WriteLine($"\nThe Price for each lemon is {pricePerLemon:0.00}. {player.Name}, how many lemons do you want to buy? \n");
            string userInput = Console.ReadLine();
            boughtLemons = Convert.ToInt32(userInput);
            double totalAmount = boughtLemons * pricePerLemon;
            if (boughtLemons > 0 && totalAmount <= moneyInWallet)
            {
                Console.WriteLine($"\nOkay, you just bought {boughtLemons} lemons for a total of ${totalAmount} \n");
                wallet.CalculateBoughtLemons(pricePerLemon, boughtLemons);
            }
            else if (boughtLemons > 0 && totalAmount > moneyInWallet)
            {
                Console.WriteLine("\nOH NO! Looks like you don't have enough money! \n");
                Console.ReadKey();
                BuyItems();
            }
            else if (boughtLemons <= 0)
            {
                Console.WriteLine("Looks like you don't want to buy any lemons \n");
                Console.ReadKey();
                BuyItems();
            }
            else
            {
                Console.WriteLine("Oops! You entered an invalid key . . . Please try again");
                BuyLemon(moneyInWallet);
            }
            wallet.DisplayWallet();
        }
        public void BuySugar(double moneyInWallet)
        {
            Console.WriteLine($"\nThe Price for each sugar cube is {pricePerSugar:0.00}. How many sugar cubes do you want to buy?\n");
            string userInput = Console.ReadLine();
            boughtSugar = Convert.ToInt32(userInput);
            double totalAmount = boughtSugar * pricePerSugar;
            if (boughtSugar > 0 && totalAmount <= moneyInWallet)
            {
                Console.WriteLine($"\nOkay, you just bought {boughtSugar} sugar cubes for a total cost of ${totalAmount}\n");
                wallet.CalculateBoughtSugar(pricePerSugar, boughtSugar);
            }
            else if (boughtSugar > 0 && totalAmount > moneyInWallet)
            {
                Console.WriteLine("\nOH NO! Looks like you don't have enough money! \n");
                Console.ReadKey();
                BuyItems();
            }
            else if (boughtSugar <= 0)
            {
                Console.WriteLine("\nLooks like you don't want to buy any sugar \n");
                Console.ReadKey();
                BuyItems();
            }
            else
            {
                Console.WriteLine("\nOops! You entered an invalid key . . . Please try again");
                BuySugar(moneyInWallet);
            }
            wallet.DisplayWallet();
        }
        public void BuyIce(double moneyInWallet)
        {
            Console.WriteLine($"\nThe Price for each ice cube is {pricePerIce:0.00}. {player.Name}, how much ice cubes do you want to buy?");
            string userInput = Console.ReadLine();
            boughtIce = Convert.ToInt32(userInput);
            double totalAmount = boughtIce * pricePerIce;
            if (boughtIce > 0 && totalAmount <= moneyInWallet)
            {
                Console.WriteLine($"\nOkay, you just bought {boughtIce} ice cubes for a total cost of ${totalAmount}");
                wallet.CalculateBoughtIce(pricePerIce, boughtIce);
            }
            else if (boughtIce > 0 && totalAmount > moneyInWallet)
            {
                Console.WriteLine("\nOH NO! Looks like you don't have enough money! \n");
                Console.ReadKey();
                BuyItems();
            }
            else if (boughtIce <= 0)
            {
                Console.WriteLine("\nLooks like you don't want to buy any ice \n");
                Console.ReadKey();
                BuyItems();
            }
            else
            {
                Console.WriteLine("\nOops! You entered an invalid key . . . Please try again");
                BuyIce(moneyInWallet);
            }
            wallet.DisplayWallet();
        }
        public void BuyCups(double moneyInWallet)
        {
            Console.WriteLine($"\nThe Price for each cup is {pricePerCup:0.00}. {player.Name}, how many cups do you want to buy?");
            string userInput = Console.ReadLine();
            boughtCups = Convert.ToInt32(userInput);
            double totalAmount = boughtCups * pricePerCup;
            if (boughtCups > 0 && totalAmount <= moneyInWallet)
            {
                Console.WriteLine($"\nOkay, you just bought {boughtCups} cups for a total cost of ${totalAmount}");
                wallet.CalculateBoughtCups(pricePerCup, boughtCups);
            }
            else if (boughtLemons > 0 && totalAmount > moneyInWallet)
            {
                Console.WriteLine("\nOH NO! Looks like you don't have enough money! \n");
                Console.ReadKey();
                BuyItems();
            }
            else if (boughtCups <= 0)
            {
                Console.WriteLine("\nLooks like you don't want to buy any cups \n");
                Console.ReadKey();
                BuyItems();
            }
            else
            {
                Console.WriteLine("\nOops! You entered an invalid key . . . Please try again");
                BuyCups(moneyInWallet);
            }
            wallet.DisplayWallet();
        }
    }
}