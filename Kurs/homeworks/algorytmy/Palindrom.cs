using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kurs.homeworks.algorytmy
{
    class Palindrom
    {

        public bool getStatus(string myString)
        {
            bool isPalenDrome = false;

            try
            {
                int halfLength = myString.Length / 2;

                string leftHalfString = myString.Substring(0, halfLength);

                char[] reversedArray = myString.ToCharArray();
                Array.Reverse(reversedArray);
                string reversedString = new string(reversedArray);

                string rightHalfStringReversed = reversedString.Substring(0, halfLength);

                isPalenDrome = leftHalfString == rightHalfStringReversed ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return isPalenDrome;
        }

        public bool IsPalenDrome(string palendromeString)
        {
            bool isPalenDrome = false;

            try
            {
                int halfLength = palendromeString.Length / 2;

                string leftHalfString = palendromeString.Substring(0, halfLength);

                char[] reversedArray = palendromeString.ToCharArray();
                Array.Reverse(reversedArray);
                string reversedString = new string(reversedArray);

                string rightHalfStringReversed = reversedString.Substring(0, halfLength);

                isPalenDrome = leftHalfString == rightHalfStringReversed ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return isPalenDrome;
        }

        public bool IsPalindrome(string str)
        {
            str = new Regex("[^a-zA-Z]").Replace(str, "").ToLower();
            return !str.Where((t, i) => t != str[str.Length - i - 1]).Any();
        }
    }
}
