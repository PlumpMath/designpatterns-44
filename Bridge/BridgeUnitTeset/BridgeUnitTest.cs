using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace BridgeUnitTeset
{
    [TestClass]
    public class BridgeUnitTest
    {
        [TestMethod]
        public void Bridge_GivenAProductAndAStateTax_CalculateTax_ReturnTax()
        {
            var tax = new TenPerscentTax();
            var netCostOfCheese = 10;
            var cheese = new Cheese(netCostOfCheese, tax);

            var actualCost = cheese.CalculateTax();
            var expectedCost = netCostOfCheese / 10m;

            IsNotNull(actualCost);
            IsTrue(actualCost > 0m);
            AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void Bridge_GivenAProductAndANationalTax_CalculateTax_ReturnTax()
        {
            var tax = new OnePercentTax();
            var netCostOfCheese = 10;
            var cheese = new Cheese(netCostOfCheese, tax);

            var actualCost = cheese.CalculateTax();
            var expectedCost = netCostOfCheese / 100m;

            IsNotNull(actualCost);
            IsTrue(actualCost > 0m);
            AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void Bridge_GivenAnListOfProducts_CalculateTaxesForAllProducts_ReturnTotal()
        {
            //arrange
            var cheese = new Cheese(100m, new TenPerscentTax());
            var milk = new Milk(10m, new TenPerscentTax());

            milk.IsLocal = false;

            var products = new List<TaxableProduct>() {
                cheese,
                milk
            };

            //act
            var actualTotal = 0m;
            foreach (var product in products)
                actualTotal += product.CalculateTax();

            //assert
            var expectedTotal = (100m / 10m) + (10m / 10m);
            AreEqual(expectedTotal, actualTotal);

            //arrange
            expectedTotal = 0;
            milk.IsLocal = true;
            cheese.IsSmelly = false;

            //assert
            actualTotal = 0m;
            foreach (var product in products)
                actualTotal += product.CalculateTax();

            AreEqual(expectedTotal, actualTotal);

        }
    }
}
