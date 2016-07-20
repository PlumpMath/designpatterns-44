using Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AdapterUnitTest
{
    [TestClass]
    public class AdapterUnitTest
    {
        [TestMethod]
        public void GivenAPig_UseFlyingAnimalAdapter_GetFlyingPig()
        {
            //arrange
            var pig = new Pig("Piggy");
            var flyingPig = new FlyingAnimalAdapter(pig);
            //act
            var actionResult = flyingPig.DoAction();

            //assert
            AreEqual(actionResult, "Piggy the Pig is flying!");
        }

        [TestMethod]
        public void GivenAPenguin_UseFlyingAnimalAdapter_GetNonFlyingPenguin()
        {
            //arrange
            var penguin = new Penguin("Eric");
            var nonFlyingPenguin = new FlyingAnimalAdapter(penguin);
            //act
            var actionResult = nonFlyingPenguin.DoAction();

            //assert
            AreEqual(actionResult, "Eric the Penguin cannot fly.");
        }
    }
}
