using System.Collections.Generic;

namespace Command
{
    using System;
    using System.IO;
    
    public class SendEmail : ICommandArgs, ICommandFactory
    {
        
        public SendEmail(string emailAddress)
        {
            EmailAddress = emailAddress;
        }

        public string CommandName { get; } = nameof(SendEmail);

        public string Description { get; } = "Send Email";

        public string EmailAddress { get; private set; } = string.Empty;

        public CommandResult Execute() => new CommandResult("Sent Email");

        public string GetUsage() => "SendEmail {email address}";

        public ICommand MakeCommand(string[] arguments)
        {
            var emailAddress = string.Empty;
            if (arguments.Length == 1)
                emailAddress = arguments[0];

            return new SendEmail(emailAddress);
        }

        public bool ValidateArguments()
        {
            return !string.IsNullOrWhiteSpace(EmailAddress);
        }
    }
}