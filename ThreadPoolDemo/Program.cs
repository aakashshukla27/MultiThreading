using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
            Employee employee = new Employee();
            employee.Name = "Aakash";
            employee.CompanyName = "Northeastern University";
            ThreadPool.QueueUserWorkItem(new WaitCallback(DisplayEmployeeInfo), employee);
            var processorCount = Environment.ProcessorCount;
            
            int workerThread = 0;
            int completionPortThreads = 0;
            ThreadPool.GetMinThreads(out workerThread, out completionPortThreads);
            ThreadPool.SetMaxThreads(workerThread * 2, completionPortThreads * 2);
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
            Console.ReadKey();
        }

        private static void DisplayEmployeeInfo(object state)
        {
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
            Employee emp = state as Employee;
            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.CompanyName);
            Console.WriteLine("Next");
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
    }
}
