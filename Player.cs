using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string Name;
        public void GetName()
        {
            Console.WriteLine("\nPLEASE ENTER YOUR NAME \n");
            Name = Console.ReadLine().ToUpper();
            if (Name.Equals(""))
            {
                Console.WriteLine("\nINVALID INPUT \n");
                GetName();
            }
        }
    }
}
