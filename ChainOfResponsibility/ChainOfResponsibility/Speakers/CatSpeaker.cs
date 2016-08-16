using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class CatSpeaker : Speaker
    {
        public CatSpeaker() : base("Crazy Cat lady")
        {
            var noSpeaker = new NoSpeaker();
            Next(noSpeaker);
        }

        public override List<DayOfWeek> GetAvailableDays() =>
            new List<DayOfWeek> { DayOfWeek.Monday };

        public override List<Topic> GetTopics() =>
            new List<Topic> { Topic.Cats };
    }
}