using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngineLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PromotionEngineTest
{
    
        [TestClass]
        public class PromotionEngineTest
        {
            [TestMethod]
            public void busFareCalculationTest1()
            {
                //Arrange
                int startPt = 2;
                int endPt = 6;
                int fare = 10;
                int stageValue = 5;
                CalculateFare cf = new CalculateFare();

                //Act
                int fareTestValue = cf.CalculateBusFareBasedOnStops(startPt, endPt, stageValue);

                //Assert
                Assert.AreEqual(fare, fareTestValue, 0, "Proper Fare");
            }
        }
}
