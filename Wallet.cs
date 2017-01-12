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
            Console.ForegroundColor = ConsoleColor.Yellow;  Console.WriteLine($"\nYou currently have ${moneyInWallet} in your wallet \n"); Console.ResetColor();
            return moneyInWallet;
        }
        public void CalculateBoughtLemons(double pricePerLemon, int boughtLemons)
        {
            double costOfLemons = pricePerLemon * boughtLemons;
            moneyInWallet = moneyInWallet - costOfLemons;
            totalMoneySpent += costOfLemons;
        }
        public void CalculateBoughtSugar(double pricePerSugar, int boughtSugar)
        {
            double costOfSugar = pricePerSugar * boughtSugar;
            moneyInWallet = moneyInWallet - costOfSugar;
            totalMoneySpent += costOfSugar;
        }
        public void CalculateBoughtIce(double pricePerIce, int boughtIce)
        {
            double costOfIce = pricePerIce * boughtIce;
            moneyInWallet = moneyInWallet - costOfIce;
            totalMoneySpent += costOfIce;
        }
        public void CalculateBoughtCups(double pricePerCup, int boughtCups)
        {
            double costOfCups = pricePerCup * boughtCups;
            moneyInWallet = moneyInWallet - costOfCups;
            totalMoneySpent += costOfCups;
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