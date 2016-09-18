using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hello_world
{
    /// <summary>
    /// Example of main windows console application class. 
    /// Prints hello world to console.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program entry point 
        /// </summary>
        /// <param name="args">CMD parameterss (ignored)</param>
        static void Main(string[] args)
        {
            new ConsoleMessagePrinter().PrintMessage("Hello world");
            //PrintHelloWorld();
        }

        ///// <summary>
        ///// Prints "Hello world" to system console
        ///// </summary>
        //public static void PrintHelloWorld()
        //{
        //    Console.WriteLine("Hello world");
        //}
    }
}
