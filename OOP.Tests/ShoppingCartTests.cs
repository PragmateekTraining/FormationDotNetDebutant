using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP.Tests
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void CanAddSomeProductsToAShoppingCart()
        {
            ShoppingCart cart = new ShoppingCart();

            string apple = "Apple";

            ShoppingCartItem apples = null;

            Assert.IsFalse(cart.TryGet(apple, out apples));
            Assert.IsNull(apples);

            cart.Add(apple);

            Assert.IsTrue(cart.TryGet(apple, out apples));
            Assert.IsNotNull(apples);
            Assert.AreEqual(1, apples.Quantity);

            cart.Add(apple, 2);

            Assert.AreEqual(1, apples.Quantity);

            Assert.IsTrue(cart.TryGet(apple, out apples));
            Assert.IsNotNull(apples);
            Assert.AreEqual(3, apples.Quantity);
        }

        [TestMethod]
        public void CanAccessTheProductsUsingTheIndexer()
        {
            ShoppingCart cart = new ShoppingCart();

            string apple = "Apple";

            cart.Add(apple, 3);

            ShoppingCartItem apples = cart[apple];

            Assert.IsNotNull(apples);
            Assert.AreEqual(3, apples.Quantity);
        }
    }
}
