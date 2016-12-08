using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        Wallet wallet = new Wallet();
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
            pricePerLemon = 0.40;
            pricePerSugar = 0.10;
            pricePerIce = 0.05;
            pricePerCup = 0.10;
        }
        public void BuyFromStore()
        {
            DisplayItemPrice();
            Wallet wallet = new Wallet();
            wallet.DisplayWallet();
            BuyItems();
        }
        public void DisplayItemPrice()
        {
            Console.WriteLine("Price for each item : \n");
            Console.WriteLine("Lemon : {0:0.00}", pricePerLemon);
            Console.WriteLine("Sugar : {0:0.00}", pricePerSugar);
            Console.WriteLine("Ice   : {0:0.00}", pricePerIce);
            Console.WriteLine("Cup   : {0:0.00}", pricePerCup);
        }
        public void BuyItems()    //// I don't think I need to give them an option for main menu 
        {
            Console.WriteLine("What item do you want to buy? Please enter the corresponding number : \n");
            Console.WriteLine("Select [1] to buy lemons");
            Console.WriteLine("Select [2] to buy sugar packets");
            Console.WriteLine("Select [3] to buy ice cubes");
            Console.WriteLine("Select [4] to buy cups");
 ///        Console.WriteLine("Select [5] to go back to the main menu");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1": 
                    BuyLemon(wallet.moneyInWallet);
                    break;
                case "2":
                    BuySugar(wallet.moneyInWallet);
                    break;
                case "3":
                    BuyIce(wallet.moneyInWallet);
                    break;
                case "4":
                    BuyCups(wallet.moneyInWallet);
                    break;
                //case "5":
                //    Game game = new Game();
                //    game.DisplayMenu();
                //    break;
                default:
                    Console.WriteLine("INVALID INPUT \n");
                    BuyItems();
                    break;
            }
        }
        public void BuyLemon(double moneyInWallet)
        {
            Console.WriteLine("The Price for each lemon is {0:0.00}. How many lemons do you want to buy?", pricePerLemon);
            string userInput = Console.ReadLine();
            buyingLemons = Convert.ToInt32(userInput);
            if (buyingLemons > 0 && costOfItems <= moneyInWallet)
            {
                Console.WriteLine("You have bought {0} lemons for a total cost of ${1}", buyingLemons, costOfItems);
                Wallet wallet = new Wallet();
                wallet.CalculateBoughtLemons(costOfItems, pricePerLemon, buyingLemons);
            }
            else if (buyingLemons > 0 && costOfItems > moneyInWallet)
            {
                Console.WriteLine("OH NO! Looks like you don't have enough money! \nPress any key to go back to the purchase menu . . .");
                Console.ReadKey();
                BuyItems();
            }
            else if (buyingLemons <= 0)
            {
                Console.WriteLine("Looks like you don't want to buy any lemons \nPress any key to go back to the purchase menu . . .");
                Console.ReadKey();
                BuyItems();
            }
            else
            {
                Console.WriteLine("Oops! You entered an invalid key . . . Please try again");
                BuyLemon(moneyInWallet);
            }
        }
        public void BuySugar(double moneyInWallet)
        {
            Console.WriteLine("The Price for each sugar packet is {0:0.00}. How many sugar packets do you want to buy?", pricePerSugar);
            string userInput = Console.ReadLine();
            buyingSugar = Convert.ToInt32(userInput);
            if (buyingSugar > 0 && costOfItems <= moneyInWallet)
            {
                Console.WriteLine("You have bought {0} sugar packets for a total cost of ${1}", buyingSugar, costOfItems);
                wallet.CalculateBoughtSugar(costOfItems, pricePerSugar, buyingSugar);
            }
            else if (buyingSugar > 0 && costOfItems > moneyInWallet)
            {
                Console.WriteLine("OH NO! Looks like you don't have enough money! \nPress any key to go back to the purchase menu . . .");
                Console.ReadKey();
                BuyItems();
            }
            else if (buyingSugar <= 0)
            {
                Console.WriteLine("Looks like you don't want to buy any sugar \nPress any key to go back to the purchase menu . . .");
                Console.ReadKey();
                BuyItems();
            }
            else
            {
                Console.WriteLine("Oops! You entered an invalid key . . . Please try again");
                BuySugar(moneyInWallet);
            }
        }
        public void BuyIce(double moneyInWallet)
        {
            Console.WriteLine("The Price for each ice cube is {0:0.00}. How much ice cubes do you want to buy?", pricePerIce);
            string userInput = Console.ReadLine();
            buyingIce = Convert.ToInt32(userInput);
            if (buyingIce > 0 && costOfItems <= moneyInWallet)
            {
                Console.WriteLine("You have bought {0} ice cubes for a total cost of ${1}", buyingIce, costOfItems);
                wallet.CalculateBoughtIce(costOfItems, pricePerIce, buyingIce);
            }
            else if (buyingLemons > 0 && costOfItems > moneyInWallet)
            {
                Console.WriteLine("OH NO! Looks like you don't have enough money! \nPress any key to go back to the purchase menu . . .");
                Console.ReadKey();
                BuyItems();
            }
            else if (buyingIce <= 0)
            {
                Console.WriteLine("Looks like you don't want to buy any ice \nPress any key to go back to the purchase menu . . .");
                Console.ReadKey();
                BuyItems();
            }
            else
            {
                Console.WriteLine("Oops! You entered an invalid key . . . Please try again");
                BuyIce(moneyInWallet);
            }
        }
        public void BuyCups(double moneyInWallet)
        {
            Console.WriteLine("The Price for each cup is {0:0.00}. How many cups do you want to buy?", pricePerCup);
            string userInput = Console.ReadLine();
            buyingCups = Convert.ToInt32(userInput);
            if (buyingCups > 0 && costOfItems <= moneyInWallet)
            {
                Console.WriteLine("You have bought {0} cups for a total cost of ${1}", buyingCups, costOfItems);
                wallet.CalculateBoughtCups(costOfItems, pricePerCup, buyingCups);
            }
            else if (buyingLemons > 0 && costOfItems > moneyInWallet)
            {
                Console.WriteLine("OH NO! Looks like you don't have enough money! \nPress any key to go back to the purchase menu . . .");
                Console.ReadKey();
                BuyItems();
            }
            else if (buyingCups <= 0)
            {
                Console.WriteLine("Looks like you don't want to buy any cups \nPress any key to go back to the purchase menu . . .");
                Console.ReadKey();
                BuyItems();
            }
            else
            {
                Console.WriteLine("Oops! You entered an invalid key . . . Please try again");
                BuyCups(moneyInWallet);
            }
        }
    }
}