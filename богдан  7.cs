﻿//В программе обработку данных оформить в качестве метода. Дана символьная строка и символ. Слово - последовательность символов между пробелами, не содержащая пробелы внутри себя. Определить количество слов в строке,оканчивающихся на заданный символ.

using System;

class Program
{
    static void Main()
    {
        string str = "Hello world! This is a sample string.";
        char ch = 'd';

        int count = CountWordsEndingWith(str, ch);

        Console.WriteLine($"Количество слов, оканчивающихся на символ '{ch}': {count}");
    }

    static int CountWordsEndingWith(string str, char ch)
    {
        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;

        foreach (string word in words)
        {
            if (word.EndsWith(ch.ToString()))
            {
                count++;
            }
        }

        return count;
    }
}
