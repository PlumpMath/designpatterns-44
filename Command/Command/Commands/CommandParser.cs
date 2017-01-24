using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Command
{
    public class CommandParser
    {
        private readonly IList<ICommandFactory> _availableCommands;

        public CommandParser()
        {
            _availableCommands = GetAvailableCommands();
        }

        public static IList<ICommandFactory> GetAvailableCommands() =>
                Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(ICommandFactory)))
                .Select(t => Activator.CreateInstance(t) as ICommandFactory)
                .ToList();

        internal ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];
            var command = FindRequestedCommand(requestedCommandName);
            return null == command ? new NotFoundCommand(requestedCommandName) : command.MakeCommand(args);
        }

        private ICommandFactory FindRequestedCommand(string commandName)
        {
            return _availableCommands
                .FirstOrDefault(cmd => cmd.CommandName.Equals(commandName, StringComparison.OrdinalIgnoreCase));
        }
    }
}