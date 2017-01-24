using Command;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommandUnitTest
{
    [TestClass]
    public class CommandUnitTest
    {
        [TestMethod]
        public void Command_GivenACommand_ReturnedFailedResult()
        {
            var c = new Command.Command();
            var result = c.DoCommand(new[] { "Explore here" });

            Assert.IsFalse(result.Successful);
        }
    }
}
