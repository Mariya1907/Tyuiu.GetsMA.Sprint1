using System;
using tyuiu.cources.programming.interfaces.Sprint1;  // ← проверь using!

namespace Tyuiu.GetsMA.Sprint1.Task6.V12.Lib
{
    public class TextService : ISprint1Task6V12
    {
        // ✅ ИМЯ МЕТОДА ИЗ ИНТЕРФЕЙСА!
        public bool CheckLastWordRepetiton(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            // Убираем знаки препинания
            text = text.Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Trim();

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length < 2)
                return false;

            // Предпоследнее == Последнее?
            return words[^2] == words[^1];
        }
    }
}

        