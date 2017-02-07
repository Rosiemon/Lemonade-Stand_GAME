using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        int thirst;
        string name;
        int money;
        Random randomCustomer = new Random();
        Inventory inventory = new Inventory();
        Store store;
        public Customer()
        {
            store = new Store(inventory);
            thirst = 0;
            name = "Default name";
            money = 0;
        }
        public void RandomizeCustomers()
        {
            thirst = randomCustomer.Next(10, 30) + randomCustomer.Next(10, 34) + randomCustomer.Next(8, 35);
            money = randomCustomer.Next(1, 30) + randomCustomer.Next(1, 34) + randomCustomer.Next(1, 30);
            string[] firstNames = new string[30] {"Mike", "Andrew", "Adam", "Nick", "Paul", "Margaret", "Christina", "Catelyn", "James", "Molly", "David", "Hannah", "Joshua", "Elizabeth", "Laura", "Erica", "John", "Mary", "Joe", "Jane", "Jason", "Alberta", "Eugine", "Mercedes", "Judy", "Angela", "Brittany", "Rose", "Jacob", "Leana"};
            string firstName = firstNames[randomCustomer.Next(0, 30)];
            name = firstName;
        }
        
        public string GetCustomerName()
        {
            return name;
        }
        public int GetCustomerThirst()
        {
            return thirst;
        }
        public int GetCustomerMoney()
        {
            return money;
        }
    }
}
