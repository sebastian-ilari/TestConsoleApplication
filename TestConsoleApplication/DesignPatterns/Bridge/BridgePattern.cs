using System;

namespace TestConsoleApplication.DesignPatterns.Bridge
{
    public class BridgePattern
    {
        public BridgePattern()
        {
            Console.WriteLine("Bridge Pattern");
            Console.WriteLine(Environment.NewLine);

            IMessageSender email = new EmailSender();
            IMessageSender queue = new MSMQSender();
            IMessageSender web = new WebServiceSender();

            Message systemMessage = new SystemMessage();
            systemMessage.Subject = "Test Message";
            systemMessage.Body = "Hi, This is a Test Message";

            systemMessage.MessageSender = email;
            systemMessage.Send();

            systemMessage.MessageSender = queue;
            systemMessage.Send();

            systemMessage.MessageSender = web;
            systemMessage.Send();

            UserMessage userMessage = new UserMessage();
            userMessage.Subject = "Test Message";
            userMessage.Body = "Hi, This is a Test Message";
            userMessage.UserComments = "I hope you are well";

            userMessage.MessageSender = email;
            userMessage.Send();

            Console.ReadKey();
        }
    }
}