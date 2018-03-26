using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace codeChallengeWebAPI.Controllers
{
    public class CodeChallenge1Controller : ApiController
    {
        
        public IEnumerable<int> get(string userInput)
        {
            userInput.Replace(" ", "");
            var _tempArray = userInput.Split(',');
            var _array = new int[_tempArray.Length];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = int.Parse(_tempArray[i]);
            }

            return SortOddOnly(_array);
        }

        private static int[] SortOddOnly(int[] _list)
        {
            var _tempList = new List<int>();
            var _tempIndex = new List<int>();

            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i] % 2 != 0)
                {
                    _tempList.Add(_list[i]);
                    _tempIndex.Add(i);
                }
            }

            _tempList.Sort();

            for (int i = 0; i < _tempList.Count; i++)
            {
                _list[_tempIndex[i]] = _tempList[i];
            }

            return _list;
        }
    }
}
