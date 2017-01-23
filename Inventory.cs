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
            Console.WriteLine("You have {0} lemons", lemonStock.Count());
            Console.WriteLine("You have {0} sugar", sugarStock.Count());
            Console.WriteLine("You have {0} ice", iceStock.Count());
            Console.WriteLine("You have {0} cups", cupStock.Count());
        }
        public void SetPrice()
        {
            Console.WriteLine("How much do you want to sell each cup of lemonade for? \n");
            string pricePerCup = Console.ReadLine().ToLower(); Convert.ToDouble(pricePerCup);
            Console.WriteLine("You are selling each cup of Lemonade for : ${0:0.00}", pricePerCup);
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
        public void AddToLemonStock()
        {
            Lemon lemon = new Lemon();
            lemonStock.Add(lemon);
        }
        public void AddToSugarStock()
        {
            Sugar sugar = new Sugar();
            sugarStock.Add(sugar);
        }
        public void AddToIceStock()
        {
            Ice ice = new Ice();
            iceStock.Add(ice);
        }
        public void AddToCupStock()
        {
            Cup cup = new Cup();
            cupStock.Add(cup);
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
            Console.WriteLine("In each cup of lemonade, you currently have : \n");
            Console.WriteLine("{0} lemons.", recipe["lemons"]);
            Console.WriteLine("{0} sugar cubes.", recipe["sugar"]);
            Console.WriteLine("{0} ice cubes.", recipe["ice"]);
            QuestionRecipe();
        }
        public void QuestionRecipe()
        {
            Console.WriteLine("Do you want to change your recipe?");
            Console.WriteLine("Select [1] for Yes");
            Console.WriteLine("Select [2] for No");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                ChangeRecipe();
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Your recipe will stay the same");
            }
            else
            {
                Console.WriteLine("INVALID INPUT \n");
                QuestionRecipe();
            }
        }
        public void ChangeRecipe()
        {
            ChangeLemonCount();
            ChangeSugarCount();
            ChangeIceCount();
        }
        public void ChangeLemonCount()
        {
            Console.WriteLine("How many lemons would you like for each cup?");
            int lemons = Int32.Parse(Console.ReadLine());
            if (lemons > lemonStock.Count)
            {
                Console.WriteLine("OH NO! Looks like you dont have enough lemons in stock . . .");
            }
            else if (lemons >= lemonStock.Count)
            {
                recipe.Add("lemons", lemons);
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
                ChangeLemonCount();
            }
        }
        public void ChangeSugarCount()
        {
            Console.WriteLine("How many sugar cubes would you like for each cup?");
            int sugar = Int32.Parse(Console.ReadLine());
            if (sugar < sugarStock.Count)
            {
                Console.WriteLine("OH NO! Looks like you dont have enough sugar in stock . . .");
            }
            else if (sugar >= sugarStock.Count)
            {
                recipe.Add("sugar", sugar);
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
                ChangeSugarCount();
            }
        }
        public void ChangeIceCount()
        {
            Console.WriteLine("How many ice cubes would you like for each cup?");
            int ice = Int32.Parse(Console.ReadLine());
            if (ice < iceStock.Count)
            {
                Console.WriteLine("OH NO! Looks like you dont have enough ice in stock . . .");
            }
            else if (ice >= iceStock.Count)
            {
                recipe.Add("ice", ice);
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
                ChangeIceCount();
            }
        }
    }
}