using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kvitto.Model;

namespace Kvitto.Tests
{
    [TestClass]
    public class ReceiptTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativePurchaseAmountThrowsException()
        {
            new Receipt(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ZeroPurchaseAmountThrowsException()
        {
            new Receipt(0);
        }

        [TestMethod]
        public void RateCalculation()
        {
            var receipt = new Receipt(50);
            Assert.AreEqual(receipt.Rate, 0);

            receipt = new Receipt(550);
            Assert.AreEqual(receipt.Rate, 0.05);

            receipt = new Receipt(1060);
            Assert.AreEqual(receipt.Rate, 0.1);

            receipt = new Receipt(5500);
            Assert.AreEqual(receipt.Rate, 0.15);
        }
    }
}
