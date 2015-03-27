namespace TestConsoleApplication.DesignPatterns.Command
{
    /// <summary>
    /// The Command for turning off the light - ConcreteCommand #2 
    /// </summary>
    public class SwitchOffCommand : ICommand
    {
        private Light light;

        public SwitchOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.TurnOff();
        }
    }
}