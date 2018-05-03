using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 8, 5, 4 };

            Console.WriteLine();
            Console.ReadKey();
        }
        #region Validate pin
        /// <summary>
        /// 
        ///Check if pin is all digit and its length is 4 or 6
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        public static bool ValidatePin(string pin)
        {
            return pin.All(n => char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);
        }
        #endregion Validate pin
        #region List names
        /// <summary>
        /// list all names of the array
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0: return "no one likes this";
                case 1: return $"{name[0]} likes this";
                case 2: return $"{name[0]} and {name[1]} like this";
                case 3: return $"{name[0]}, {name[1]} and {name[2]} like this";
                default: return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }
        #endregion List names
        #region sum of two smallest numbers
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.Where(item => item % 2 == 0 && item > 0).Sum();
        }
        #endregion sum of two smallest numbers
        #region sum of all positives in an array
        /// <summary>
        /// sum of all positives in an array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int PositiveSum(int[] arr)
        {
            return arr.Where(item => item > 0).Sum();
        }
        #endregion sum of all positives in an array
        #region convert binary array into decimal representation
        /// <summary>
        /// convert binary array into decimal representation
        /// </summary>
        /// <param name="BinaryArray"></param>
        /// <returns></returns>
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            String s = "";
            foreach (int i in BinaryArray)
            {
                s += i;
            }
            return Convert.ToInt32(s, 2);
        }
        #endregion convert binary array into decimal representation
        #region version 1: 4of Fo1r pe6ople g3ood th5e the2 ==> Fo1r the2 g3ood 4of th5e
        /// <summary>
        /// Order input string by the numbers they contain
        /// Example: 4of Fo1r pe6ople g3ood th5e the2 ==> Fo1r the2 g3ood 4of th5e
        /// </summary>
        /// <param name="words"></param>
        /// <returns>ordered string</returns>
        public static string OrderWords(string words)
        {
            string result = "";

            SortedDictionary<int, string> st = new SortedDictionary<int, string>();

            string[] temp = words.Split(null);
            foreach (string c in temp)
            {
                foreach (char t in c)
                {
                    if (t >= '0' && t <= '9')
                    {
                        st.Add(Convert.ToInt32(t), c);
                    }
                }
            }
            foreach (KeyValuePair<int, string> a in st)
            {
                result += a.Value + " ";
            }
            return result;
        }
        #endregion version 1: 4of Fo1r pe6ople g3ood th5e the2 ==> Fo1r the2 g3ood 4of th5e
        #region version 2: 4of Fo1r pe6ople g3ood th5e the2 ==> Fo1r the2 g3ood 4of th5e
        /// <summary>
        /// Order input string by the numbers they contain variant 2
        /// 4of Fo1r pe6ople g3ood th5e the2
        /// </summary>
        /// 


        public static string OrderWordsV2(string words)
        {
            string b = "ffgfgdg4";
            string a = new string(b.Where(char.IsDigit).ToArray());
            return string.Join(" ", words.Split(null).OrderBy(c => new string(c.Where(char.IsDigit).ToArray())));
        }

        #endregion version 2: 4of Fo1r pe6ople g3ood th5e the2 ==> Fo1r the2 g3ood 4of th5e
        #region remove all spacess
        /// <summary>
        /// remove all spacess
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }
        #endregion remove all spacess
        #region if perfect square
        /// <summary>
        /// check if <c>num</c> is perfect square. If true- return next square
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static long FindNextSquare(long num)
        {
            double n = Math.Sqrt(num);
            return n == (int)n ? Convert.ToInt64(Math.Pow(n + 1, 2)) : -1;
        }
        #endregion if perfect square
        #region factorial of given number
        /// <summary>
        /// calculate factorial for a given input. If input is below 0 or above 12
        /// throw an exception of type ArgumentOutOfRangeException
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Factorial(int n)
        {
            if (n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
                return Enumerable.Range(1, n).Aggregate(1, (a, b) => a * b);
        }
        #endregion factorial of given number
        #region version 1: Find max(abs(length(x) − length(y)))
        /// <summary>
        /// You are given two arrays a1 and a2 of strings. Each string is composed with letters from a to z.
        /// Let x be any string in the first array and y be any string in the second array.
        /// Find max(abs(length(x) − length(y)))
        /// </summary>
        /// <param name="a1">first string</param>
        /// <param name="a2">second string</param>
        /// <returns></returns>
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            List<int> l = new List<int>();

            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    l.Add(Math.Abs((a1[i].Length) - (a2[j].Length)));
                }
            }

            return l.Max();
        }
        #endregion version 1: Find max(abs(length(x) − length(y)))
        #region version 2: Find max(abs(length(x) − length(y)))
        /// <summary>
        /// You are given two arrays a1 and a2 of strings. Each string is composed with letters from a to z.
        /// Let x be any string in the first array and y be any string in the second array.
        /// Find max(abs(length(x) − length(y)))
        /// </summary>
        /// <param name="a1">first string</param>
        /// <param name="a2">second string</param>
        /// <returns></returns>
        public static int MxdiflgV2(List<string> a1, List<string> a2)
        {
            return a1.Count <= 0 || a2.Count <= 0 ? -1 : Math.Max(Math.Abs(a1.Max(s => s.Length) - a2.Min(s => s.Length)), Math.Abs(a1.Min(s => s.Length) - a2.Max(s => s.Length)));
        }
        #endregion version 2: Find max(abs(length(x) − length(y)))
        #region even ascending, odds descending
        /// <summary>
        /// Sort all even numbers in ascending order and odd numbers in descending order
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SortArray(int[] array) => array.Where(x => x % 2 == 0).OrderBy(x => x).ToArray().Union(array.Where(x => x % 2 != 0).OrderByDescending(x => x).ToArray()).ToArray();

        #endregion even ascending, odds descending
        #region version 1: Sort all odd numbers, do not change positions of even numbers
        /// <summary>
        /// Sort all odd numbers, do not change position of even numbers
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SortArrayOdds(int[] array)
        {
            int[] sorted = array.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();

            int c = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    array[i] = sorted[c];
                    c++;
                }
            }
            return array;
        }

        #endregion version 1: Sort all odd numbers, do not change positions of even numbers
        #region varsion 2: Sort all odd numbers, do not change positions of even numbers
        /// <summary>
        /// Sort all odd numbers, do not change position of even numbers
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        /// 
        //public static int[] SortArrayOddsV2(int[] array)
        //{
        //}
            #endregion varsion 2: Sort all odd numbers, do not change positions of even numbers
        }
}
