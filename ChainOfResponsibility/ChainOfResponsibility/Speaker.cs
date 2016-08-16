using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public abstract class Speaker : ISpeaker
    {
        private ISpeaker _nextSpeaker;
        private List<DayOfWeek> _availableDays;
        private List<Topic> _knownTopics;
        private string _name;

        protected Speaker(string name)
        {
            _name = name;
            _availableDays = GetAvailableDays() ?? new List<DayOfWeek>();
            _knownTopics = GetTopics() ?? new List<Topic>();
        }

        public virtual bool CanSpeak(DayOfWeek day, Topic topic)
        {
            if (!IsBusy(day) && KnowsTopic(topic))
            {
                Console.Write($"{_name} will talk about {topic} on {day}");
                return true;
            }
            else
            {
                return _nextSpeaker.CanSpeak(day, topic);
            }
        }

        public bool IsBusy(DayOfWeek day) => !_availableDays.Contains(day);

        public bool KnowsTopic(Topic topic) => _knownTopics.Contains(topic);

        public ISpeaker Next(ISpeaker nextSpeaker)
        {
            _nextSpeaker = nextSpeaker;
            return _nextSpeaker;
        }

        public abstract List<DayOfWeek> GetAvailableDays();
        public abstract List<Topic> GetTopics();
    }
}
