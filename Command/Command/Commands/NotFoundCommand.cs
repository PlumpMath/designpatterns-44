namespace Command
{
    public class NotFoundCommand : ICommand
    {
        private readonly string _commandName;

        public NotFoundCommand(string commandName)
        {
            _commandName = commandName;
        }

        public CommandResult Execute() => new CommandResult($"Couldn't find command: {_commandName}", false);
        
    }
}