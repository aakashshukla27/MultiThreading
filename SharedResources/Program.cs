using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharedResources
{
    class Program
    {
        private static bool isCompleted;
        static readonly object lockCompleted = new object();
        static void Main(string[] args)
        {
            Thread thread = new Thread(HelloWorld);
            //Worker Thread
            thread.Start();

            //Main thread
            HelloWorld();
            Console.ReadKey();
        }

        private static void HelloWorld()
        {
            if (!isCompleted)
            {
                lock (lockCompleted)
                {
                    isCompleted = true;
                    Console.WriteLine("Hello World should print only once.");                    
                }
                
            }
           
        }
    }
}
