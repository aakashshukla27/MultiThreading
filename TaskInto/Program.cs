using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskInto
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(SimpleMethod);
            task.Start();

            Task<string> taskThatReturnValue = new Task<string>(MethodThatReturnsValue);
            taskThatReturnValue.Start();

            taskThatReturnValue.Wait();
            Console.WriteLine(taskThatReturnValue.Result);
        }

        private static string MethodThatReturnsValue()
        {
            Thread.Sleep(2000);
            return "Hello";
        }

        private static void SimpleMethod()
        {
            Console.WriteLine("Hello World");
        }
    }
}
