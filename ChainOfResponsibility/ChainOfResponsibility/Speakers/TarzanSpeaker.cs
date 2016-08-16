using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class TarzanSpeaker : Speaker
    {
        public TarzanSpeaker() : base("Tarzan") {
            var noSpeaker = new NoSpeaker();
            Next(noSpeaker);
        }

        public override List<DayOfWeek> GetAvailableDays() =>
            new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Friday };

        public override List<Topic> GetTopics() =>
            new List<Topic> { Topic.Monkeys };
    }
}