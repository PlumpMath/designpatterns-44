using Builder;
using Builder.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace BuilderUnitTest
{
    [TestClass]
    public class BuilderUnitTest
    {
        /*
        public House BuildHouse<T>()
        {
            HouseBuilder houseBuilder = new T();
            var siteManager = new SiteManager(houseBuilder);

            siteManager.BuildHouse();
            return siteManager.GetHouse();
        }
        */


        [TestMethod]
        public void Builder_GivenTownHouseBuilder_BuildsBeachHouse()
        {
            var houseBuilder = new BeachHouseBuilder();
            var siteManager = new SiteManager(houseBuilder);

            siteManager.BuildHouse();
            var house = siteManager.GetHouse();

            IsNotNull(house);
            AreEqual("Beach", house.Type);
            Console.Write(house);
        }

    }
}
