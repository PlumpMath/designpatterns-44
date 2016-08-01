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

        public House BuildHouse<T>() where T : HouseBuilder, new()
        {
            HouseBuilder houseBuilder = new T();
            var siteManager = new SiteManager(houseBuilder);
            siteManager.BuildHouse();
            return siteManager.GetHouse();
        }

        [TestMethod]
        public void Builder_GivenBeachHouseBuilder_BuildsBeachHouse()
        {
            var house = BuildHouse<BeachHouseBuilder>();

            IsNotNull(house);
            AreEqual("Beach", house.Type);
            Console.Write(house);
        }

        [TestMethod]
        public void Builder_GivenTownHouseBuilder_BuildsTownHouse()
        {
            var house = BuildHouse<TownHouseBuilder>();

            IsNotNull(house);
            AreEqual("Town", house.Type);
            Console.Write(house);
        }

        [TestMethod]
        public void Builder_GivenMansionBuilder_BuildsMansionHouse()
        {
            var house = BuildHouse<MansionHouseBuilder>();

            IsNotNull(house);
            AreEqual("Mansion", house.Type);
            Console.Write(house);
        }
    }
}
