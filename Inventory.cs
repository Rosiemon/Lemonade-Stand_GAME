using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemon> lemonStock;
        public List<Sugar> sugarStock;
        public List<Ice> iceStock;
        public List<Cup> cupStock;
        public Dictionary<string, int> recipe;
        double sellingPrice;

        public Inventory()
        {
            lemonStock = new List<Lemon> { };
            sugarStock = new List<Sugar> { };
            iceStock = new List<Ice> { };
            cupStock = new List<Cup> { };
            recipe = new Dictionary<string, int>();
            recipe.Add("lemons", 1);
            recipe.Add("sugar", 1);
            recipe.Add("ice", 1);
        }

        public void DisplayInventory()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Your current Inventory: \n");
            Console.WriteLine("You have {0} lemons", lemonStock.Count());
            Console.WriteLine("You have {0} sugar", sugarStock.Count());
            Console.WriteLine("You have {0} ice", iceStock.Count());
            Console.WriteLine("You have {0} cups \n", cupStock.Count()); Console.ResetColor();
        }
        public void SetPrice()
        {
            Console.WriteLine("How much do you want to sell each cup of lemonade for? \n");
            string setSellingPrice = Console.ReadLine().ToLower();
            sellingPrice = Double.Parse(setSellingPrice);
            double maxLimit = 40;
            try
            {
                if (sellingPrice == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("\nIn order to make a profit you need to set your price higher than $0.00"); Console.ResetColor();
                }
                else if (sellingPrice >= maxLimit)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("\nAre you just trying to make fun? \nLet's be a little bit more realistic with the price of your lemonade!"); Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("\nOkay great! You are going to sell each cup of Lemonade for : ${0:0.00}", sellingPrice);
                }
            }
            catch
            {
                Console.WriteLine("INVALID INPUT \n");
            }
         }

        public int GetLemonCount()
        {
            return lemonStock.Count();
        }
        public int GetSugarCount()
        {
            return sugarStock.Count();
        }
        public int GetIceCount()
        {
            return iceStock.Count();
        }
        public int GetCupCount()
        {
            return cupStock.Count();
        }
        public void AddToLemonStock(int boughtLemons)
        {
            for (int i = 0; i < boughtLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemonStock.Add(lemon);
            }
        }
        public void AddToSugarStock(int boughtSugar)
        {
            for (int i = 0; i < boughtSugar; i++)
            {
                Sugar sugar = new Sugar();
                sugarStock.Add(sugar);
            }
        }
        public void AddToIceStock(int boughtIce)
        {
            for (int i = 0; i < boughtIce; i++)
            {
                Ice ice = new Ice();
                iceStock.Add(ice);
            }
        }
        public void AddToCupStock(int boughtCups)
        {
            for (int i = 0; i < boughtCups; i++)
            {
                Cup cup = new Cup();
                cupStock.Add(cup);
            }
        }
        public void RemoveLemonStock()
        {
            lemonStock.RemoveAt(0);
        }
        public void RemoveSugarStock()
        {
            sugarStock.RemoveAt(0);
        }
        public void RemoveIceStock()
        {
            iceStock.RemoveAt(0);
        }
        public void RemoveCupStock()
        {
            cupStock.RemoveAt(0);
        }
        public void DisplayRecipe()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;  Console.WriteLine("In each cup of lemonade, you currently have : \n");
            Console.WriteLine("{0} lemons", recipe["lemons"]);
            Console.WriteLine("{0} sugar cubes", recipe["sugar"]);
            Console.WriteLine("{0} ice cubes \n", recipe["ice"]); Console.ResetColor();
            DisplayInventory();
            QuestionRecipe(); 
        }
        public void QuestionRecipe()
        {
            Console.WriteLine("Do you want to change your recipe? \n");
            Console.WriteLine("Select [1] YES");
            Console.WriteLine("Select [2] NO");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "1" || userInput == "y" || userInput == "yes")
            {
                ChangeRecipe(); 
            }
            else if (userInput == "2" || userInput == "n" || userInput == "no")
            {
                Console.WriteLine("\nAlright, your recipe will stay the same");
            }
            else
            {
                Console.WriteLine("INVALID INPUT \n");
                QuestionRecipe();
            }
        }
        public void ChangeRecipe()
        {
            if (lemonStock.Count <= 0 || sugarStock.Count <= 0 || iceStock.Count <= 0)
            {
                Console.WriteLine("You appear to have nothing in stock. You need to buy your items from the store first.");
            }
            else
            {
                ChangeLemonCount();
                ChangeSugarCount();
                ChangeIceCount();
            }
        }
        public void ChangeLemonCount()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("How many lemons would you like for each cup?");
            int lemons = Int32.Parse(Console.ReadLine());
            if (lemons > lemonStock.Count)
            {
                Console.WriteLine("OH NO! Looks like you dont have enough lemons in stock . . ."); Console.ResetColor();
            }
            else if (lemons <= lemonStock.Count)
            {
                recipe.Add("lemons", lemons); Console.ResetColor();
            }
            else
            {
                Console.WriteLine("INVALID INPUT"); Console.ResetColor();
                ChangeLemonCount();
            }
        }
        public void ChangeSugarCount()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("How many sugar cubes would you like for each cup?");
            int sugar = Int32.Parse(Console.ReadLine());
            if (sugar > sugarStock.Count)
            {
                Console.WriteLine("OH NO! Looks like you dont have enough sugar in stock . . ."); Console.ResetColor();
            }
            else if (sugar <= sugarStock.Count)
            {
                recipe.Add("sugar", sugar); Console.ResetColor();
            }
            else
            {
                Console.WriteLine("INVALID INPUT"); Console.ResetColor();
                ChangeSugarCount();
            }
        }
        public void ChangeIceCount()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("How many ice cubes would you like for each cup?");
            int ice = Int32.Parse(Console.ReadLine());
            if (ice > iceStock.Count)
            {
                Console.WriteLine("OH NO! Looks like you dont have enough ice in stock . . ."); Console.ResetColor();
            }
            else if (ice <= iceStock.Count)
            {
                recipe.Add("ice", ice); Console.ResetColor();
            }
            else
            {
                Console.WriteLine("INVALID INPUT"); Console.ResetColor();
                ChangeIceCount();
            }
        }
    }
}