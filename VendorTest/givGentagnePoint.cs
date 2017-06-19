using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineCustomerLoyaltyPrgAndTestNS;

namespace VendorTest
{
    [TestClass]
    public class givGentagnePoint
    {

        ProductVendor Hat_ProdVendor;
        Customer customer;
        Customer customer2;

       
        [TestInitialize]
        public void Setup()
        {
            Hat_ProdVendor = new ProductVendor(1000);
            customer = new Customer();
            customer2 = new Customer();
        }

        [TestMethod]
        public void requireZoroItems()
        {
            int points = Hat_ProdVendor.requirePoints(customer, 0, 0);
            Assert.AreEqual(0, points);
        }

        [TestMethod]
        public void requirePointDestinctItemsTwoDescinctCustomers()
        {
            // an item
            int points = Hat_ProdVendor.requirePoints(customer, 1, 1);
            Assert.AreEqual(5, points);

            // another item
            points = Hat_ProdVendor.requirePoints(customer, 2, 1);
            Assert.AreEqual(11, points);

            // Second Customer
            // an item
            points = Hat_ProdVendor.requirePoints(customer2, 1, 1);
            Assert.AreEqual(5, points);

            // another item
            points = Hat_ProdVendor.requirePoints(customer2, 2, 1);
            Assert.AreEqual(11, points);
        }

        [TestMethod]
        public void requirePointsTwoItemsDistinctCustomers()
        {
            // two of an item
            int points = Hat_ProdVendor.requirePoints(customer, 1, 2);
            Assert.AreEqual(10, points);

            // two of another item
            points = Hat_ProdVendor.requirePoints(customer, 2, 2);
            Assert.AreEqual(22, points);

            // Second Customer
            // an item
            points = Hat_ProdVendor.requirePoints(customer2, 1, 1);
            Assert.AreEqual(5, points);

            // another item
            points = Hat_ProdVendor.requirePoints(customer2, 2, 1);
            Assert.AreEqual(11, points);

            // first item again, two of them
            points = Hat_ProdVendor.requirePoints(customer2, 1, 2);
            Assert.AreEqual(10, points);


        }
    }
}
