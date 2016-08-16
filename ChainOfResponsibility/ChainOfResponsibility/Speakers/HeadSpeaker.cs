using System;
using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsibility
{
    public class HeadSpeaker : Speaker
    {
        public HeadSpeaker() : base("Head speaker") {
            var noSpeaker = new NoSpeaker();
            Next(noSpeaker);
        }

        public override List<DayOfWeek> GetAvailableDays()
        {
            var wholeWeek = Enumerable.Range(0, 6).ToList().Cast<DayOfWeek>().ToList();
            var availableDays = new List<DayOfWeek>();
            availableDays.AddRange(wholeWeek);
            return availableDays;
        }

        public override List<Topic> GetTopics()
        {
            return null;
        }
    }
}