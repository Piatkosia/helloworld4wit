using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.IO;

namespace Hello_world
{
   
    public class HelloWorldText
    {
        [Fact]
        public void IsHelloworldPrinted()
        {
            //arrange
            IMessagePrinter printer = new TestMessagePrinter();
            //var output = new StringWriter();
            //Console.SetOut(output);
            
            //act
            printer.PrintMessage("Hello world");
            //Program.PrintHelloWorld();
            //Program.Main(null);
           
            //assert
            Assert.Equal( ((TestMessagePrinter)printer).LastPrintedMessage, "Hello world");
            //Assert.Equal(output.GetStringBuilder().ToString().Trim(),"Hello world");


        }
    }
}
