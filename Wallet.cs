using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double moneyInWallet;
        public double moneySpentToday;
        public double moneyEarnedToday;
        public double totalMoneySpent;
        public double totalMoneyEarned;
        public double profitEarned;
        public Wallet()
        {
            moneyInWallet = 20.00;
        }
        public double DisplayWallet()
        {
            Console.WriteLine($"You currently have ${moneyInWallet} in your wallet");
            return moneyInWallet;
        }
        public void CalculateBoughtLemons(double costOfItems, double pricePerLemon, int buyingLemons)
        {
            costOfItems = pricePerLemon * buyingLemons;
            moneyInWallet = costOfItems - moneyInWallet;
            totalMoneySpent += costOfItems;
        }
        public void CalculateBoughtSugar(double costOfItems, double pricePerSugar, int buyingSugar)
        {
            costOfItems = pricePerSugar * buyingSugar;
            moneyInWallet = costOfItems - moneyInWallet;
            totalMoneySpent += costOfItems;
        }
        public void CalculateBoughtIce(double costOfItems, double pricePerIce, int buyingIce)
        {
            costOfItems = pricePerIce * buyingIce;
            moneyInWallet = costOfItems - moneyInWallet;
            totalMoneySpent += costOfItems;
        }
        public void CalculateBoughtCups(double costOfItems, double pricePerCup, int buyingCups)
        {
            costOfItems = pricePerCup * buyingCups;
            moneyInWallet = costOfItems - moneyInWallet;
            totalMoneySpent += costOfItems;
        }
        public double DisplayDailyExpense()
        {
            return moneySpentToday;
        }
        public double DisplayDailyProfit(double pricePerCup, int cupsSold)
        {
            moneyEarnedToday = cupsSold * pricePerCup;
            return moneyEarnedToday;
        }
        public double DisplayTotalExpense(double dailyReport)   
        {
            totalMoneySpent += dailyReport;
            return totalMoneySpent;
        }
        public double DisplayTotalProfit(double dailyReport)     
        {
            totalMoneyEarned += dailyReport;
            return totalMoneyEarned;
        }

        /////////////////////////////////////////////////////////////// GET THIS DONE

        public void ResetDailyExpense()
        {

        }
        public void ResetDailyProfit()
        {

        }
    }
}