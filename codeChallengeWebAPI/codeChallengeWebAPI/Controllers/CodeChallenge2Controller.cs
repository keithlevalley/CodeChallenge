using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace codeChallengeWebAPI.Controllers
{
    public class CodeChallenge2Controller : ApiController
    {
        public string get(string userInput)
        {
            return MiddleLetter(userInput);
        }

        private static string MiddleLetter(string _word)
        {
            if (_word == "")
                return _word;

            else if (_word.Length % 2 != 0)
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
