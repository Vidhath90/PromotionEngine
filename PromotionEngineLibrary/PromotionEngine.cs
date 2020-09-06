using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineLibrary
{
    public class PromotionEngine
    {
        static bool calculated = false;
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
        public int CalculateTotalAfterPromotions(Dictionary<string, int> userCart)
        {

            int total = 0;
            int value, promotionPrice;
            var userCartCondition = userCart.Keys;
            foreach (String cartondition in userCartCondition)
            {

                switch (cartondition)
                {
                    case "A":
                        total += BillItemA(userCart);
                        break;
                    case "B":
                        total += BillItemB(userCart);
                        break;
                    case "C":
                    case "D":
                        total += BillItemC_D(userCart);
                        break;


                }

            }
            return total;
        }
        private int BillItemA(Dictionary<string, int> userCart)
        {
            int aTotal = 0, totalNonPromotionItems, promotionPrice;

            if (ActivePromotions.PromotionPrice["A"].Quantity <= userCart["A"])
            {
                totalNonPromotionItems = userCart["A"] % ActivePromotions.PromotionPrice["A"].Quantity;
                totalNonPromotionItems = totalNonPromotionItems * UnitPricing.UnitPrice["A"];
                promotionPrice = ActivePromotions.PromotionPrice["A"].Price * (userCart["A"] / ActivePromotions.PromotionPrice["A"].Quantity);

                aTotal = aTotal + promotionPrice + totalNonPromotionItems;

            }
            else
                aTotal = userCart["A"] * UnitPricing.UnitPrice["A"];

            return aTotal;
        }

        private int BillItemB(Dictionary<string, int> userCart)
        {
            int bTotal = 0, totalNonPromotionItems, promotionPrice;

            if (ActivePromotions.PromotionPrice["B"].Quantity <= userCart["B"])
            {
                totalNonPromotionItems = userCart["B"] % ActivePromotions.PromotionPrice["B"].Quantity;
                totalNonPromotionItems = totalNonPromotionItems * UnitPricing.UnitPrice["B"];
                promotionPrice = ActivePromotions.PromotionPrice["B"].Price * (userCart["B"] / ActivePromotions.PromotionPrice["B"].Quantity);

                bTotal = bTotal + promotionPrice + totalNonPromotionItems;

            }
            else
                bTotal = userCart["A"] * UnitPricing.UnitPrice["A"];

            return bTotal;
        }
        private int BillItemC_D(Dictionary<string, int> userCart)
        {
            int cdTotal = 0, totalCItems, totalDItems;
            totalCItems = userCart["C"];
            totalDItems = userCart["D"];
            if (!calculated)
            {
                calculated = true;
                
                if (totalCItems > 0 && totalDItems > 0)
                {

                    cdTotal = totalCItems > totalDItems ? ((totalCItems * ActivePromotions.PromotionPrice["C&D"].Price)) + ((totalCItems - totalDItems) * ActivePromotions.PromotionPrice["C"].Price) : (totalDItems * ActivePromotions.PromotionPrice["C&D"].Price + ((totalDItems - totalCItems) * ActivePromotions.PromotionPrice["D"].Price));

                }
                else
                {
                    cdTotal = totalCItems == 0 ? totalDItems * UnitPricing.UnitPrice["D"] : totalCItems * UnitPricing.UnitPrice["C"];
                }
            }
                return cdTotal;
            }
        
    }
}
