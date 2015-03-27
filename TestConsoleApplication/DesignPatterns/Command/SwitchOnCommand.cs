namespace TestConsoleApplication.DesignPatterns.Command
{
    /// <summary>
    /// The Command for turning on the light - ConcreteCommand #1 
    /// </summary>
    public class SwitchOnCommand : ICommand
    {
        private Light light;

        public SwitchOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.TurnOn();
        }
    }
}