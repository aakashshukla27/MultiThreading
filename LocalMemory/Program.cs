using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LocalMemory
{
    class Program
    {
        static void Main(string[] args)
        {   
            //worker thread
            new Thread(printOneToThirty).Start();
            //main thread
            printOneToThirty();
        }

        private static void printOneToThirty()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
