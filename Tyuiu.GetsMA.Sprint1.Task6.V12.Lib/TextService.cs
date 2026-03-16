using System;
using tyuiu.cources.programming.interfaces.Sprint1;  // ✅ using!

namespace Tyuiu.GetsMA.Sprint1.Task6.V12.Lib
{
    public class TextService : ISprint1Task6V12  // ✅ БЕЗ ПРОБЕЛОВ!
    {
        public bool CheckLastWordRepetiton(string text)  // ✅ Точное имя!
        {
            if (string.IsNullOrWhiteSpace(text)) return false;

            text = text.Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Trim();
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length < 2) return false;

            return string.Equals(words[^2], words[^1], StringComparison.OrdinalIgnoreCase);
        }
    }
}


