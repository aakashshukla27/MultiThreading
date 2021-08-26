using System;
using System.Threading.Tasks;

namespace IOBoundTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> task = Task.Factory.StartNew<string>(() => 
            GetPosts("https://jsonplaceholder.typicode.com/posts"));

            SomethingElse();
          
            task.Wait();
            try
            {
                Console.WriteLine(task.Result);
            }
            catch(AggregateException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static void SomethingElse()
        {
            // Dummy implementation
        }

        private static string GetPosts(string url)
        {
            using(var client = new System.Net.WebClient())
            {
                return client.DownloadString(url);
            }
        }
    }
}
