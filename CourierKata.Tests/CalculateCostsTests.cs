using System;
using System.Collections.Generic;
using CourierKata;
using NUnit.Framework;
namespace CourierKata.Tests
{
    public class CalculateCostsTests
    {
        [Test]
        public void ShouldCalculateNormalDeliveryCost()
        {
            Parcel p1 = new Parcel("Small", 3.00, 1);
            Parcel p2 = new Parcel("Heavy", 50.00, 50);

            var testShoppingCart = new ShoppingCart();
            testShoppingCart.ParcelItems = new List<Parcel>();
            var speedyDelivery = false;
            testShoppingCart.ParcelItems.Add(p1);
            testShoppingCart.ParcelItems.Add(p2);


            var result = testShoppingCart.TotalCost(speedyDelivery);

            Assert.That(result, Is.EqualTo(53));
        }
        [Test]
        public void ShouldCalculateSpeedyDeliveryCost()
        {
            Parcel p1 = new Parcel("Small", 3.00, 1);
            Parcel p2 = new Parcel("Heavy", 50.00, 50);

            var testShoppingCart = new ShoppingCart();
            testShoppingCart.ParcelItems = new List<Parcel>();
            var speedyDelivery = true;
            testShoppingCart.ParcelItems.Add(p1);
            testShoppingCart.ParcelItems.Add(p2);


            var result = testShoppingCart.TotalCost(speedyDelivery);

            Assert.That(result, Is.EqualTo(106));
        }
        [Test]
        public void ShouldCalculateNormalDeliveryWithVaryingWeight()
        {
            Parcel p1 = new Parcel("Small", 3.00, 5);
            Parcel p2 = new Parcel("Heavy", 50.00, 50);

            var testShoppingCart = new ShoppingCart();
            testShoppingCart.ParcelItems = new List<Parcel>();
            var speedyDelivery = false;
            testShoppingCart.ParcelItems.Add(p1);
            testShoppingCart.ParcelItems.Add(p2);


            var result = testShoppingCart.TotalCost(speedyDelivery);

            Assert.That(result, Is.EqualTo(61));
        }

        [Test]
        public void ShouldCalculateSpeedyDeliveryWithVaryingWeight()
        {
            Parcel p1 = new Parcel("Small", 3.00, 5);
            Parcel p2 = new Parcel("Heavy", 50.00, 50);

            var testShoppingCart = new ShoppingCart();
            testShoppingCart.ParcelItems = new List<Parcel>();
            var speedyDelivery = true;
            testShoppingCart.ParcelItems.Add(p1);
            testShoppingCart.ParcelItems.Add(p2);


            var result = testShoppingCart.TotalCost(speedyDelivery);

            Assert.That(result, Is.EqualTo(122));
        }
    }
}
