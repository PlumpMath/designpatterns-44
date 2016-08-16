using ChainOfResponsibility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ChainOfResponsibilityUnitTest
{
    [TestClass]
    public class ChainOfResponsibilityUnitTest
    {
        private static HeadSpeaker BuildFullChain()
        {
            var speakingChain = new HeadSpeaker();
            speakingChain.Next(new CatSpeaker())
                .Next(new TarzanSpeaker())
                .Next(new VetSpeaker());
            return speakingChain;
        }

        [TestMethod]
        public void ChainOfResponsibility_GivenAnHeadSpeakerOnly_ReturnsFalse()
        {
            var headSpeaker = new HeadSpeaker();
            var canFindSpeaker = headSpeaker.CanSpeak(DayOfWeek.Monday, Topic.Cats);

            IsFalse(canFindSpeaker);
        }

        [TestMethod]
        public void ChainOfResponsibility_GivenAnSmallChainSpeakers_ReturnsTrue()
        {
            var speakingChain = new HeadSpeaker();
            speakingChain.Next(new CatSpeaker());

            var foundSpeaker = speakingChain.CanSpeak(DayOfWeek.Monday, Topic.Cats);

            IsTrue(foundSpeaker);
        }

        [TestMethod]
        public void ChainOfResponsibility_GivenAnLargeChainSpeakers_ReturnsTrue()
        {
            HeadSpeaker speakingChain = BuildFullChain();

            var foundSpeaker = speakingChain.CanSpeak(DayOfWeek.Saturday, Topic.Monkeys);

            IsTrue(foundSpeaker);
        }


        [TestMethod]
        public void ChainOfResponsibility_GivenAnLargerChainSpeakers_ReturnsTrue()
        {
            var speakingChain = BuildFullChain();

            var foundSpeaker = speakingChain.CanSpeak(DayOfWeek.Thursday, Topic.Monkeys);

            IsTrue(foundSpeaker);
        }

        [TestMethod]
        public void ChainOfResponsibility_GivenAnLargerChainSpeakers_ReturnsFalse()
        {
            var speakingChain = BuildFullChain();

            var foundSpeaker = speakingChain.CanSpeak(DayOfWeek.Wednesday, Topic.Crocodiles);

            IsFalse(foundSpeaker);
        }

        [TestMethod]
        public void ChainOfResponsibility_GivenAnLargerChainSpeakers_ReturnsNoSpeakerFalse()
        {
            var speakingChain = BuildFullChain();

            var foundSpeaker = speakingChain.CanSpeak(DayOfWeek.Tuesday, Topic.Dogs);

            IsFalse(foundSpeaker);
        }
    }
}
