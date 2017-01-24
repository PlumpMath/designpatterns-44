namespace Command
{
    public interface ICommandArgs : ICommand
    {
        bool ValidateArguments();

        string GetUsage();

    }
}