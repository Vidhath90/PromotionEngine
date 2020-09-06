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
        [TestMethod]
        public void PromotionEngineTest_CalculateWrongTotal()
        {

            //Arrange
            int actualTotal = 270;
            Dictionary<string, int> userCart = new Dictionary<string, int>();
            userCart.Add("A", 5);
            PromotionEngine pe = new PromotionEngine();

            //Act
            int total = pe.CalculateTotalAfterPromotions(userCart);

            //Assert
            Assert.AreEqual(actualTotal, total, 0, "Wrong Total");

        }

        [TestMethod]
        public void PromotionEngineTest_CalculateTotal()
        {

            //Arrange
            int actualTotal = 205;
            Dictionary<string, int> userCart = new Dictionary<string, int>();
            userCart.Add("A", 3);
            userCart.Add("B", 2);
            userCart.Add("C", 1);
            userCart.Add("D", 1);
            PromotionEngine pe = new PromotionEngine();

            //Act
            int total = pe.CalculateTotalAfterPromotions(userCart);

            //Assert
            Assert.AreEqual(actualTotal, total, 0, "Correct Total");

        }

    }
}
