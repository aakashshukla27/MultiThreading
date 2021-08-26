using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContextSwitching
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteUsingNewThread);
            // Worker Thread
            thread.Name = "Worker 1";
            thread.Start();
            // Main Thread
            Thread.CurrentThread.Name = "Main Thread Context Switching";
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("A = " + i);
            }
        }

        private static void WriteUsingNewThread()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Z = " + i);
            }
        }
    }
}
