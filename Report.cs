using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Report
    {
        Wallet wallet;
        public Report()
        {
            wallet = new Wallet();
        }
        public void DisplayDailyReport(int currentDay)
        {
            Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("||||||||||| SALES REPORT FOR THE DAY ||||||||||");
            Console.WriteLine("Date : {0}", DateTime.Today);
            Console.WriteLine("Day : {0}", currentDay);
            Console.WriteLine("Profit   : {0}", wallet.moneyEarnedToday);
            Console.WriteLine("Expenses : {0} \n", wallet.moneySpentToday); Console.ResetColor();
            DisplayTotalReport();
        }
        public void DisplayTotalReport()
        {
            Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("||||||||||| RUNNING SALES REPORT ||||||||||");
            Console.WriteLine("TOTAL Business Expenses : {0}", wallet.totalMoneySpent);
            Console.WriteLine("TOTAL Business Profits  : {0} \n", wallet.totalMoneyEarned); Console.ResetColor();
        }
    }
}
