using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using StockPromotionEngine;

namespace StockPromotionEngineTest
{
    [TestClass]
    public class PromotionEngineTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalculatePromotion calculatePromotion = new CalculatePromotion();
            calculatePromotion.ActivePromotionCalculation(1, 1, 1, 0);
        }
        [TestMethod]
        public void TestMethod2()
        {
            CalculatePromotion calculatePromotion = new CalculatePromotion();
            calculatePromotion.ActivePromotionCalculation(5, 5, 1, 0);
        }
        [TestMethod]
        public void TestMethod3()
        {
            CalculatePromotion calculatePromotion = new CalculatePromotion();
            calculatePromotion.ActivePromotionCalculation(3, 5, 1, 1);
        }
        [TestMethod]
        public void TestMethod4()
        {
            CalculatePromotion calculatePromotion = new CalculatePromotion();
            calculatePromotion.ActivePromotionCalculation(3, 5, 7, 2);
        }
        [TestMethod]
        public void TestMethod5()
        {
            CalculatePromotion calculatePromotion = new CalculatePromotion();
            calculatePromotion.ActivePromotionCalculation(3, 5, 9, 7);
        }


    }
}
