using System;
using System.Collections.Generic;
using PromotionEngineLibrary;

namespace UserCartBilling
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> CustomerOrders = new Dictionary<string, int>();
            string input;

            Console.WriteLine("Enter the product and quanity by comma seperated");
            for (int i = 0; i < 4; i++)
            {
                input = Console.ReadLine();
                string[] words = input.Split(',');
                CustomerOrders.Add(words[0].ToUpper(), Convert.ToInt32(words[1]));
            }
            PromotionEngine pe = new PromotionEngine();
            Console.WriteLine(pe.CalculateTotalAfterPromotions(CustomerOrders));
            Console.ReadKey();


        }
    }
}
