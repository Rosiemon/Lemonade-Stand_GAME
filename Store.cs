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
        public double pricePerLemon;
        public double pricePerSugar;
        public double pricePerIce;
        public double pricePerCup;
        public double costOfItems;
        public int buyingLemons;
        public int buyingSugar;
        public int buyingIce;
        public int buyingCups;
        public Store()
        {
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
            Console.WriteLine("Select [2] Buy Sugar Packets");
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
                default:
                    Console.WriteLine("INVALID INPUT \n");
                    BuyItems();
                    break;
            }
        }
        public void BuyLemon(double moneyInWallet)
        {
            Console.WriteLine("\nThe Price for each lemon is {0:0.00}. How many lemons do you want to buy? \n", pricePerLemon);
            string userInput = Console.ReadLine();
            buyingLemons = Convert.ToInt32(userInput);
            if (buyingLemons > 0 && costOfItems <= moneyInWallet)
            {
                Console.WriteLine("\n have bought {0} lemons for a total cost of ${1} \n", buyingLemons, costOfItems);
                Wallet wallet = new Wallet();
                wallet.CalculateBoughtLemons(costOfItems, pricePerLemon, buyingLemons);
            }
            else if (buyingLemons > 0 && costOfItems > moneyInWallet)
            {
                Console.WriteLine("\nOH NO! Looks like you don't have enough money! \n");
                Console.ReadKey();
                BuyItems();
            }
            else if (buyingLemons <= 0)
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
            Console.WriteLine("\nThe Price for each sugar packet is {0:0.00}. How many sugar packets do you want to buy?\n", pricePerSugar);
            string userInput = Console.ReadLine();
            buyingSugar = Convert.ToInt32(userInput);
            if (buyingSugar > 0 && costOfItems <= moneyInWallet)
            {
                Console.WriteLine("\nYou have bought {0} sugar packets for a total cost of ${1}\n", buyingSugar, costOfItems);
                wallet.CalculateBoughtSugar(costOfItems, pricePerSugar, buyingSugar);
            }
            else if (buyingSugar > 0 && costOfItems > moneyInWallet)
            {
                Console.WriteLine("\nOH NO! Looks like you don't have enough money! \n");
                Console.ReadKey();
                BuyItems();
            }
            else if (buyingSugar <= 0)
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
            Console.WriteLine("\nThe Price for each ice cube is {0:0.00}. How much ice cubes do you want to buy?", pricePerIce);
            string userInput = Console.ReadLine();
            buyingIce = Convert.ToInt32(userInput);
            if (buyingIce > 0 && costOfItems <= moneyInWallet)
            {
                Console.WriteLine("\nYou have bought {0} ice cubes for a total cost of ${1}", buyingIce, costOfItems);
                wallet.CalculateBoughtIce(costOfItems, pricePerIce, buyingIce);
            }
            else if (buyingLemons > 0 && costOfItems > moneyInWallet)
            {
                Console.WriteLine("\nOH NO! Looks like you don't have enough money! \n");
                Console.ReadKey();
                BuyItems();
            }
            else if (buyingIce <= 0)
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
            Console.WriteLine("\nThe Price for each cup is {0:0.00}. How many cups do you want to buy?", pricePerCup);
            string userInput = Console.ReadLine();
            buyingCups = Convert.ToInt32(userInput);
            if (buyingCups > 0 && costOfItems <= moneyInWallet)
            {
                Console.WriteLine("\nYou have bought {0} cups for a total cost of ${1}", buyingCups, costOfItems);
                wallet.CalculateBoughtCups(costOfItems, pricePerCup, buyingCups);
            }
            else if (buyingLemons > 0 && costOfItems > moneyInWallet)
            {
                Console.WriteLine("\nOH NO! Looks like you don't have enough money! \n");
                Console.ReadKey();
                BuyItems();
            }
            else if (buyingCups <= 0)
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