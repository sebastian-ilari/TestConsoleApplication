using System.Collections.Generic;

namespace TestConsoleApplication.DesignPatterns.Command
{
    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    public class Switch
    {
        private List<ICommand> commands = new List<ICommand>();

        public void StoreAndExecute(ICommand command)
        {
            this.commands.Add(command);
            command.Execute();
        }
    }
}