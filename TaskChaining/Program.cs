using System;
using System.Threading.Tasks;
namespace TaskChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> antecedent = Task.Run(()
                =>
                {
                    Task.Delay(10000);
                    return DateTime.Today.ToShortDateString();
                });
            Task<string> continuation = antecedent.ContinueWith(x => "Today is " + antecedent.Result);
            Console.WriteLine("This will display before result");
            Console.WriteLine(continuation.Result);
        }
    }
}
