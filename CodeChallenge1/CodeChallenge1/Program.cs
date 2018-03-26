using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialArray = new int[] { 5, 3, 2, 8, 1, 4 };

            Console.Write("initial array: ");

            foreach(var number in initialArray)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            var sortedArray = SortOddOnly(initialArray);

            Console.Write("sorted array: ");

            foreach (var number in sortedArray)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            initialArray = new int[] { 6, 3, 2, 7, 5, 0 };

            Console.Write("initial array: ");

            foreach (var number in initialArray)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            sortedArray = SortOddOnly(initialArray);

            Console.Write("sorted array: ");

            foreach (var number in sortedArray)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        public static int[] SortOddOnly(int[] _list)
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
