using System.Diagnostics;
using task1;

namespace TestLinkedListByIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedlist = Testing.GetLinkedList();

            for (int i = 0 ; i < 100; i++)
            {
                var watch = Stopwatch.StartNew();
                Testing.LinkedListByIndex(linkedlist);
                Console.WriteLine($"Вставка заняла {watch.Elapsed.TotalMilliseconds} мс");
                watch.Stop();
            }
        }
    }
}