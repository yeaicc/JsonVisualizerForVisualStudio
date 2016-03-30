using JsonVisualizerForVisualStudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string text = "{\"id\":123}";
            JsonVisualizer.TestShowVisualizer(text);
            Console.ReadLine();
        }
    }
}
