using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Hello_world;

namespace HelloFromWpf
{
    public class WpfMessagePrinter : IMessagePrinter
    {
        public void PrintMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
