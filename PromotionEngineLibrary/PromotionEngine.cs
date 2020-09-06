using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineLibrary
{
   public  class PromotionEngine
    {
        private Dictionary<string, PerItemQuantityPrice> activePromotions = new Dictionary<string, PerItemQuantityPrice>();
        public PromotionEngine()
        {
            FillActivePromotions();
        }
        private void FillActivePromotions()
        {
            activePromotions.Add("A", new PerItemQuantityPrice { Quantity = 3, Price = 130 });
            activePromotions.Add("B", new PerItemQuantityPrice { Quantity = 2, Price = 45 });
            activePromotions.Add("C", new PerItemQuantityPrice { Quantity = 0, Price = 0 });
            activePromotions.Add("D", new PerItemQuantityPrice { Quantity = 0, Price = 0 });
            activePromotions.Add("C&D", new PerItemQuantityPrice { Quantity = 1, Price = 30 });
            ActivePromotions.PromotionPrice = activePromotions;
        }
        public int CalculateTotalAfterPromotions(Dictionary<string,int> userCart)
        {

            int total = 0; 

            return total;
        }

    }
}
