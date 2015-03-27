using System;
using TestConsoleApplication.DesignPatterns.Adapter;
using TestConsoleApplication.DesignPatterns.Bridge;
using TestConsoleApplication.DesignPatterns.Builder;
using TestConsoleApplication.DesignPatterns.Command;
using TestConsoleApplication.DesignPatterns.Composite;
using TestConsoleApplication.DesignPatterns.Decorator;
using TestConsoleApplication.DesignPatterns.Facade;
using TestConsoleApplication.DesignPatterns.Factory;
using TestConsoleApplication.DesignPatterns.Prototype;
using TestConsoleApplication.DesignPatterns.Proxy;
using TestConsoleApplication.DesignPatterns.Singleton;
using TestConsoleApplication.DesignPatterns.Strategy;
using TestConsoleApplication.PolymorphicEmployee;

namespace TestConsoleApplication
{
    public class DesignPatternsMain
    {
        public static void Start(string[] args)
        {
            Console.WriteLine("a. PolymorphicEmployee");
            Console.WriteLine("b. Strategy Pattern");
            Console.WriteLine("c. Adapter Pattern");
            Console.WriteLine("d. Factory Pattern");
            Console.WriteLine("e. Decorator Pattern");
            Console.WriteLine("f. Singleton Pattern");
            Console.WriteLine("g. Command Pattern");
            Console.WriteLine("h. Builder Pattern");
            Console.WriteLine("i. Composite Pattern");
            Console.WriteLine("j. Bridge Pattern");
            Console.WriteLine("k. Prototype Pattern");
            Console.WriteLine("m. Facade Pattern");
            Console.WriteLine("n. Proxy Pattern");

            Console.Write("\nChoose an option: ");

            ConsoleKeyInfo console = Console.ReadKey();

            switch (console.KeyChar)
            {
                case 'a':
                    Console.Clear();
                    new PolymorphicEmployeeExample();
                    break;

                case 'b':
                    Console.Clear();
                    new StrategyPattern();
                    break;

                case 'c':
                    Console.Clear();
                    new AdapterPattern();
                    break;

                case 'd':
                    Console.Clear();
                    new FactoryPattern();
                    break;

                case 'e':
                    Console.Clear();
                    new DecoratorPattern();
                    break;

                case 'f':
                    Console.Clear();
                    new SingletonPattern();
                    break;

                case 'g':
                    Console.Clear();
                    new CommandPattern();
                    break;

                case 'h':
                    Console.Clear();
                    new BuilderPattern();
                    break;

                case 'i':
                    Console.Clear();
                    new CompositePattern();
                    break;

                case 'j':
                    Console.Clear();
                    new BridgePattern();
                    break;

                case 'k':
                    Console.Clear();
                    new PrototypePattern();
                    break;

                case 'm':
                    Console.Clear();
                    new FacadePattern();
                    break;

                case 'n':
                    Console.Clear();
                    new ProxyPattern();
                    break;

                default:
                    Console.WriteLine("\n\nInvalid character");
                    Console.ReadKey();
                    break;
            }
        }
    }
}