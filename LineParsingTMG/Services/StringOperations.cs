using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineParsingTMG.Services
{
    public class StringOperations
    {
        public int CountWordsInLine(string inputString)
        {
            return inputString.Split(' ', '—').Length;
        }
        public int CountVowelsInLine(string inputString)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'а', 'у', 'е', 'ы', 'о', 'э', 'я', 'и', 'ю' };

            return inputString.ToLower().Count(x => vowels.Contains(x));
        }
    }
}
