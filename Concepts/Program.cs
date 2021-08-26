using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintHelloWorld);
            //Worker Thread
            thread.Start();
            thread.IsBackground = true;
            thread.Join(); // waiting for this thread to finish
            Console.WriteLine("Hello World Printed");  
        }

        private static void PrintHelloWorld()
        {
            Console.WriteLine("Hello");
            Thread.Sleep(5000);
        }
    }
}
