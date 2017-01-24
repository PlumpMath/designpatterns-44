namespace Command
{
    public class CommandResult
    {
        public CommandResult(string result, bool successful = true)
        {
            Result = result;
        }

        public bool Successful { get; private set; }
        public string Result { get; private set; }
    }
}