namespace Command
{
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public class Command
    {
        public CommandResult DoCommand(string[] args)
        {
            if (args.Length == 0) throw new ArgumentException("No command specified");

            var availableCommands = CommandParser.GetAvailableCommands();

            var parser = new CommandParser();
            var command = parser.ParseCommand(args);

            if (HasValidArguments(command))
                return command.Execute();

            return new CommandResult("No command executed", false);
        }

        private bool HasValidArguments(ICommand command)
        {
            const bool IsValid = true;
            if (!(command is ICommandArgs)) return IsValid;

            var commandArgs = (ICommandArgs)command;
            if (commandArgs.ValidateArguments()) return IsValid;

            return false;
        }

        private IList<string> GetCommands(IList<ICommandFactory> availableCommands) => 
            availableCommands
                .OrderBy(c => c.CommandName)
                .Select(command => $"{command.CommandName} {command.Description}")
                .ToList();
    }
}