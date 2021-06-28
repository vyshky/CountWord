using System;
using System.Text;

namespace CountWord
{
    class Program
    {
        static void Main()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine($"Количество слов : {CountWord(str)}");
        }

        static int CountWord(string str)
        {
            int count = 0;
            int i = 0;
            bool word;
            do
            {
                word = true;
                while (!char.IsLetter(str, i) && i < str.Length - 1)
                {
                    i++;
                    word = false;
                }

                if (word && i != str.Length - 1) i++;

                if (char.IsLetter(str, i - 1) && char.IsLetter(str, i))
                {
                    count++;
                    while (char.IsLetter(str, i) && i < str.Length - 1)
                    {
                        i++;
                    }
                }

            } while (i < str.Length - 1);

            return count;
        }
    }
}
