using System.Collections.Generic;
using System.Text;

namespace StringTransformation
{
    class EntryPoint
    {
        /// <summary>
        /// Entrypoint to program.
        /// </summary>
        static void Main()
        {
            Dictionary<char, string> latinSymbols = new Dictionary<char, string>
            {
                ['а'] = "a",
                ['б'] = "b",
                ['в'] = "v",
                ['г'] = "g",
                ['д'] = "d",
                ['е'] = "e",
                ['ё'] = "e",
                ['ж'] = "zh",
                ['з'] = "z",
                ['и'] = "i",
                ['й'] = "y",
                ['к'] = "k",
                ['л'] = "l",
                ['м'] = "m",
                ['н'] = "n",
                ['о'] = "o",
                ['п'] = "p",
                ['р'] = "r",
                ['с'] = "s",
                ['т'] = "t",
                ['у'] = "u",
                ['ф'] = "f",
                ['х'] = "kh",
                ['ц'] = "ts",
                ['ч'] = "ch",
                ['ш'] = "sh",
                ['ы'] = "y",
                ['э'] = "e",
                ['ю'] = "yu",
                ['я'] = "ya"
            };

            Dictionary<string, char> cyrillicSymbols = new Dictionary<string, char>
            {
                ["a"] = 'а',
                ["b"] = 'б',
                ["v"] = 'в',
                ["g"] = 'г',
                ["d"] = 'д',
                ["e"] = 'е',
                ["e"] = 'ё',
                ["zh"] = 'ж',
                ["z"] = 'з',
                ["i"] = 'и',
                ["y"] = 'й',
                ["k"] = 'к',
                ["l"] = 'л',
                ["m"] = 'м',
                ["n"] = 'н',
                ["o"] = 'о',
                ["p"] = 'п',
                ["r"] = 'р',
                ["s"] = 'с',
                ["t"] = 'т',
                ["u"] = 'у',
                ["f"] = 'ф',
                ["kh"] = 'х',
                ["ts"] = 'ц',
                ["ch"] = 'ч',
                ["sh"] = 'ш',
                ["y"] = 'ы',
                ["e"] = 'э',
                ["yu"] = 'ю',
                ["ya"] = 'я'
            };

            
            string word = "word";
            

            for (int i = 0; i < word.Length; i++)
            {
                foreach (string key in cyrillicSymbols.Keys) {
                    if (word[i] == key)
            }


        }
    }
}