using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public static class ActivePromotions
    {
        public static Dictionary<string,PerItemQuantityPrice> PromotionPrice
        { get; set; }

    }
    public class PerItemQuantityPrice
    {
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
