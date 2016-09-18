using System;

namespace Hello_world
{
    public class ConsoleMessagePrinter : IMessagePrinter
    {
        /// <summary>
        /// Print message to system console
        /// </summary>
        /// <param name="message">message to print</param>
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
