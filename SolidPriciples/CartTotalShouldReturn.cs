﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidPriciples.Model;

namespace SolidPriciples
{
    [TestClass]
    public class CartTotalShouldReturn
    {

        private Refactored.Cart _cart;

        [TestInitialize]
        public void SetUp()
        {
            _cart = new Refactored.Cart();
        }

        [TestMethod]
        public void ZeroWhenEmpty()
        {
            Assert.AreEqual(0, _cart.TotalAmount());
        }

        [TestMethod]
        public void FiveWithOneEachItem()
        {
            _cart.Add(new OrderItem() { Quantity = 1, Sku = "EACH_WIDGET" });
            Assert.AreEqual(5.0m, _cart.TotalAmount());
        }

        [TestMethod]
        public void TwoWithHalfKiloWeightItem()
        {
            _cart.Add(new OrderItem() { Quantity = 500, Sku = "WEIGHT_PEANUTS" });
            Assert.AreEqual(2m, _cart.TotalAmount());
        }

        [TestMethod]
        public void EightyCentsWithTwoSpecialItem()
        {
            _cart.Add(new OrderItem() { Quantity = 2, Sku = "SPECIAL_CANDYBAR" });
            Assert.AreEqual(0.80m, _cart.TotalAmount());
        }
        [TestMethod]
        public void TwoDollarsWithSixSpecialItem()
        {
            _cart.Add(new OrderItem() { Quantity = 6, Sku = "SPECIAL_CANDYBAR" });
            Assert.AreEqual(2m, _cart.TotalAmount());
        }
        [TestMethod]
        public void FourDollarsWithFourBuy4Get1FreeItems()
        {
            _cart.Add(new OrderItem() { Quantity = 4, Sku = "B4GO_APPLE" });
            Assert.AreEqual(4m, _cart.TotalAmount());
        }
        [TestMethod]
        public void FourDollarsWithFiveBuy4Get1FreeItems()
        {
            _cart.Add(new OrderItem() { Quantity = 5, Sku = "B4GO_APPLE" });
            Assert.AreEqual(4m, _cart.TotalAmount());
        }
    }
}