using task1;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wordlist = Testing.GetArray(); //Список всех слов в тексте
            var wordset = new HashSet<string>(wordlist); //Множество уникальных слов в тексте
            int counter = 0;

            //Список пар (Слово - Кол-во повторений)
            List<(string word, int count)> wordcount = new();

            foreach (string item in wordset)
            {
                foreach (string word in wordlist)
                    if (word == item)
                        counter++;

                wordcount.Add((item, counter));
                counter = 0;
            }

            wordcount.Sort((x, y) => y.count.CompareTo(x.count)); //Сортировка по счетчику

            //Вывод первых десяти значений
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"{wordcount[i].word}: {wordcount[i].count}");
        }
    }
}