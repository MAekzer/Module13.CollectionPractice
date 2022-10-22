namespace task1
{
    public static class Testing
    {
        //Создает массив слов из текстового файла
        public static string[] GetArray()
        {
            string filepath = @"C:\Users\ekser\Desktop\Text1.txt";

            using StreamReader sr = new(filepath);
            string text = sr.ReadToEnd();

            var newText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] separators = { ' ', '\n', '\r' };

            string[] array = newText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return array;
        }

        //Создает связаный список
        public static LinkedList<string> GetLinkedList()
        {
            string filepath = @"C:\Users\ekser\Desktop\Text1.txt";

            using StreamReader sr = new(filepath);
            string text = sr.ReadToEnd();

            var newText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] separators = { ' ', '\n', '\r' };

            LinkedList<string> linkedtext = new(newText.Split(separators, StringSplitOptions.RemoveEmptyEntries));
            return linkedtext;
        }

        //Создает список
        public static List<string> GetList()
        {
            string filepath = @"C:\Users\ekser\Desktop\Text1.txt";

            using StreamReader sr = new(filepath);
            string text = sr.ReadToEnd();

            var newText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            char[] separators = { ' ', '\n', '\r' };

            List<string> listtext = new(newText.Split(separators, StringSplitOptions.RemoveEmptyEntries));
            return listtext;
        }

        //Вставка в список по индексу
        public static void ListByIndex(List<string> list)
        {
            list.Insert(1, "abcd");
        }

        //Вставка в связаный список по индексу
        public static void LinkedListByIndex(LinkedList<string> list)
        {
            int counter = 0;

            foreach (var node in list)
            {
                if (counter == 1)
                {
                    list.AddBefore(list.Find(node), "abcd");
                    return;
                }
                counter++;
            }
        }

        //Вставка в список по значению
        public static void ListByValue(List<string> list)
        {
            list.Insert(list.IndexOf("Обломов"), "abcd");
        }

        //Вставка в связаный список по значению
        public static void LinkedListByValue(LinkedList<string> list)
        {
            list.AddBefore(list.Find("Обломов"), "abcd");
        }
    }
}
