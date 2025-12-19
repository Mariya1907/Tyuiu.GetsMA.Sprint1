using System;
using Tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GetsMA.Sprint1.Task6.V12.Lib
{
    // Класс должен быть public
    public class TextService : ISprint1Task6V12
    {
        // Метод должен быть public
        public bool IsLastWordRepeated(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length < 2)
                return false;

            string lastWord = words[^1]; // Последнее слово

            // Проверяем, встречается ли оно ранее
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (string.Equals(words[i], lastWord, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }
    }
}
