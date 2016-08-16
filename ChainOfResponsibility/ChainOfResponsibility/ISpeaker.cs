using System;

namespace ChainOfResponsibility
{
    public interface ISpeaker
    {
        bool CanSpeak(DayOfWeek day, Topic topic);

        bool KnowsTopic(Topic topic);

        bool IsBusy(DayOfWeek day);

        ISpeaker Next(ISpeaker speaker);
    }
}
