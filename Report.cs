using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Report
    {
        Wallet wallet = new Wallet();
        public void DisplayDailyReport(int currentDay)
        {
            Console.WriteLine("||||||||||| SALES REPORT FOR THE DAY ||||||||||");
            Console.Write("Day : {0}     ", currentDay);
            Console.WriteLine("Date : {0}", DateTime.Today);
            Console.WriteLine("Expenses : {0}", wallet.moneySpentToday);
            Console.WriteLine("Profit   : {0} \n", wallet.moneyEarnedToday);
            DisplayTotalReport();
        }
        public void DisplayTotalReport()
        {
            Console.WriteLine("||||||||||| RUNNING SALES REPORT ||||||||||");
            Console.WriteLine("TOTAL Business Expenses : {0}", wallet.totalMoneySpent);
            Console.WriteLine("TOTAL Business Profits  : {0} \n", wallet.totalMoneyEarned);
        }
    }
}
