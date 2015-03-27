using System;
namespace TestConsoleApplication.DesignPatterns.Command
{
    public class CommandPattern
    {
        public CommandPattern()
        {
            Console.WriteLine("Command Pattern");
            Console.WriteLine(Environment.NewLine);
            
            Console.Write("Enter Commands (on/off): ");
            string command = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);

            Light lamp = new Light();
            
            ICommand switchOn = new SwitchOnCommand(lamp);
            ICommand switchOff = new SwitchOffCommand(lamp);

            Switch interruptor = new Switch();

            if (command.Equals("on"))
            {
                interruptor.StoreAndExecute(switchOn);
            }
            else if (command.Equals("off"))
            {
                interruptor.StoreAndExecute(switchOff);
            }
            else
            {
                Console.WriteLine("Command \"on\" or \"off\" is required.");
            }

            Console.ReadKey();
            Console.WriteLine(Environment.NewLine);
        }
    }
}