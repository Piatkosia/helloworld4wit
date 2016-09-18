using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
    public interface IMessagePrinter
    {
        /// <summary>
        /// Print message taken from parameter
        /// </summary>
        /// <param name="message"> Message to print</param>
        void PrintMessage(string message);
    }
}
