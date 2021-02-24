using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using StockPromotionEngine;
using System.IO;

namespace StockPromotionEngineTest
{
    [TestClass]
    public class PromotionEngineTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                CalculatePromotion calculatePromotion = new CalculatePromotion();
                calculatePromotion.ActivePromotionCalculation(1, 1, 1, 0);
                var result = sw.ToString();
                NUnit.Framework.Assert.AreEqual("100", result);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                CalculatePromotion calculatePromotion = new CalculatePromotion();
                calculatePromotion.ActivePromotionCalculation(5, 5, 1, 0);
                var result = sw.ToString();
                NUnit.Framework.Assert.AreEqual("370", result);
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                CalculatePromotion calculatePromotion = new CalculatePromotion();
                calculatePromotion.ActivePromotionCalculation(3, 5, 1, 1);
                var result = sw.ToString();
                NUnit.Framework.Assert.AreEqual("280", result);
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                CalculatePromotion calculatePromotion = new CalculatePromotion();
                calculatePromotion.ActivePromotionCalculation(3, 5, 7, 2);
                var result = sw.ToString();
                NUnit.Framework.Assert.AreEqual("410", result);
            }
        }
        [TestMethod]
        public void TestMethod5()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                CalculatePromotion calculatePromotion = new CalculatePromotion();
                calculatePromotion.ActivePromotionCalculation(3, 5, 9, 7);
                var result = sw.ToString();
                NUnit.Framework.Assert.AreEqual("500", result);
            }
        }
    }
}
