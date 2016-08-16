using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class VetSpeaker : Speaker
    {
        public VetSpeaker() : base("Vet")
        {
            var noSpeaker = new NoSpeaker();
            Next(noSpeaker);
        }

        public override List<DayOfWeek> GetAvailableDays() =>
            new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday };

        public override List<Topic> GetTopics() =>
            new List<Topic> { Topic.Cats, Topic.Crocodiles, Topic.Dogs, Topic.Monkeys };
    }
}