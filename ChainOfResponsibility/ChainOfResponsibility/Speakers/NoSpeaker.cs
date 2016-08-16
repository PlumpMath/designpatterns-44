using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class NoSpeaker : Speaker
    {
        public NoSpeaker() : base("No speaker")
        {
            //No Next Speaker
        }

        public override bool CanSpeak(DayOfWeek day, Topic topic)
        {
            return false;
        }

        public override List<DayOfWeek> GetAvailableDays() =>
            new List<DayOfWeek>();

        public override List<Topic> GetTopics() =>
            new List<Topic>();
    }
}