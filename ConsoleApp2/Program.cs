using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var DrinkDb = new DrinkContext())
            using (var CustomerDb = new CustomerContext())
            {
                DrinkDb.Drinks.Add(new Drink { Name = "Example Drink" });
                DrinkDb.SaveChanges();
                CustomerDb.Customers.Add(new Customer { FullName = "Example Customer" });
                CustomerDb.SaveChanges();

                foreach (var item in DrinkDb.Drinks)
                {
                    Console.WriteLine(item.Name);
                }
                foreach (var item in CustomerDb.Customers)
                {
                    Console.WriteLine(item.FullName);
                }
                Console.WriteLine("done");
                Console.ReadKey();
            }
        }
    }
}
