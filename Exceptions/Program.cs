using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
        }

        private static void Demo()
        {
            // Exception handling happens on every thread 
            try
            {
                //Worker Thread
                new Thread(Execute).Start();
            }
            // Running on main thread
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Execute()
        {
            throw null;
        }
    }
}
