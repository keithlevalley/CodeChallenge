using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            string _word = "dog";

            Console.WriteLine(_word + ": " + MiddleLetter(_word));

            _word = "Fishing";

            Console.WriteLine(_word + ": " + MiddleLetter(_word));

            _word = "have";

            Console.WriteLine(_word + ": " + MiddleLetter(_word));

            _word = "Middle";

            Console.WriteLine(_word + ": " + MiddleLetter(_word));

            _word = "C";

            Console.WriteLine(_word + ": " + MiddleLetter(_word));

            _word = "Cd";

            Console.WriteLine(_word + ": " + MiddleLetter(_word));

            _word = "";

            Console.WriteLine(_word + ": " + MiddleLetter(_word));

        }

        public static string MiddleLetter(string _word)
        {
            if (_word == "")
                return _word;

            else if(_word.Length % 2 != 0)
            {
                return _word[(_word.Length / 2)].ToString();
            }
            else
            {
                return _word.Substring((_word.Length / 2) - 1, 2);
            }
        }
    }
}
