using System.Collections.Generic;
using PromotionEngineLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PromotionEngineTest
{

    [TestClass]
        public class PromotionEngineTest
        {
            [TestMethod]
            public void PromotionEngineTest_CalculateRightTotal()
            {

            //Arrange
            int actualTotal = 230;
            Dictionary<string, int> userCart = new Dictionary<string, int>();
            userCart.Add("A", 5);
            PromotionEngine pe = new PromotionEngine();

            //Act
            int total = pe.CalculateTotalAfterPromotions(userCart);

            //Assert
            Assert.AreEqual(actualTotal, total, 0, "Proper Total");

        }
        }
}
