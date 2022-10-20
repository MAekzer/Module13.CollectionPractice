using System.Diagnostics;
using task1;

namespace TestListByValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Testing.GetList();

            for (int i = 0; i < 100; i++)
            {
                var watch = Stopwatch.StartNew();
                Testing.ListByValue(list);
                Console.WriteLine($"Вставка заняла {watch.Elapsed.TotalMilliseconds} мс");
                watch.Stop();
            }
        }
    }
}