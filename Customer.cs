using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        Weather weather = new Weather();
        Wallet wallet;
        Inventory inventory;
        public int cupsSold;
        public double moneyEarnedToday;
        public Customer()
        {
            wallet = new Wallet();
            inventory = new Inventory();
        }
        public void BuyingCustomers()
        {
            if (weather.actualTemperature > 29 && weather.actualTemperature < 41)
            {
                Console.WriteLine("No one bought lemonade today. . .");
                wallet.DisplayWallet();
            }
            else if (weather.actualTemperature > 39 && weather.actualTemperature < 46)
            {
                Console.WriteLine("Only 4 customers stopped by today adn bought lemonade.");
                cupsSold = 4;
                moneyEarnedToday = cupsSold * inventory.sellingPrice;
                double totalBalance = moneyEarnedToday + wallet.moneyInWallet;
                wallet.DisplayWallet();
            }
            else if (weather.actualTemperature > 45 && weather.actualTemperature < 56)
            {
                Console.WriteLine("12 customers stopped by today and bought lemonade.");
                cupsSold = 12;
                moneyEarnedToday = cupsSold * inventory.sellingPrice;
                double totalBalance = moneyEarnedToday + wallet.moneyInWallet;
                wallet.DisplayWallet();
            }
            else if (weather.actualTemperature > 55 && weather.actualTemperature < 66)
            {
                Console.WriteLine("21 customers stopped by today and bought lemonade.");
                cupsSold = 21;
                moneyEarnedToday = cupsSold * inventory.sellingPrice;
                double totalBalance = moneyEarnedToday + wallet.moneyInWallet;
                wallet.DisplayWallet();
            }
            else if (weather.actualTemperature > 65 && weather.actualTemperature < 76)
            {
                Console.WriteLine("34 customers stopped by today and bought lemonade.");
                cupsSold = 34;
                moneyEarnedToday = cupsSold * inventory.sellingPrice;
                double totalBalance = moneyEarnedToday + wallet.moneyInWallet;
                wallet.DisplayWallet();
            }
            else if (weather.actualTemperature > 75 && weather.actualTemperature < 85)
            {
                Console.WriteLine("46 customers stopped by today and bought lemonade.");
                cupsSold = 46;
                moneyEarnedToday = cupsSold * inventory.sellingPrice;
                double totalBalance = moneyEarnedToday + wallet.moneyInWallet;
                wallet.DisplayWallet();
            }
            else if (weather.actualTemperature > 84 && weather.actualTemperature < 94)
            {
                Console.WriteLine("58 customers stopped by today and bought lemonade.");
                cupsSold = 58;
                moneyEarnedToday = cupsSold * inventory.sellingPrice;
                double totalBalance = moneyEarnedToday + wallet.moneyInWallet;
                wallet.DisplayWallet();
            }
            else if (weather.actualTemperature > 93 && weather.actualTemperature < 101)
            {
                Console.WriteLine("72 customers stopped by today and bought lemonade.");
                cupsSold = 72;
                moneyEarnedToday = cupsSold * inventory.sellingPrice;
                double totalBalance = moneyEarnedToday + wallet.moneyInWallet;
                wallet.DisplayWallet();
            }
            else
            {
                Console.WriteLine("there was an error with customers . . . . .");
            }
        }
    }
}