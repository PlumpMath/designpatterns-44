using System.Collections.Generic;

namespace Command
{
    using System;

    public class GetTime : ICommand, ICommandFactory
    {
        public string CommandName { get; } = nameof(GetTime);

        public string Description { get; } = "Gets the current time";
        
        public CommandResult Execute() => new CommandResult(DateTime.Now.ToShortTimeString());

        public ICommand MakeCommand(string[] arguments) => new GetTime();
    }
}