using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngineLibrary;

namespace UserCartBilling
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> CustomerOrders = new Dictionary<string, int>();
            string input;
            Console.WriteLine("Enter the product and quanity in order");
            input = Console.ReadLine();
            string[] words = input.Split(',');
            CustomerOrders.Add(words[0], Convert.ToInt32(words[1]));
            PromotionEngine pe = new PromotionEngine();
            Console.WriteLine(pe.CalculateTotalAfterPromotions(CustomerOrders));
            Console.ReadKey();


        }
    }
}
