using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCLib
{
    public class PalindromeFinder
    {
        public bool IsPalindrome(string value)
        {
            bool isPalindromeValue = false;
            
            if(value == null)
                throw new ArgumentNullException();
            if (value.Length <= 1)
                throw new ArgumentException("Error: Input number/word must have more than 1 digits/characters.");
            if (value.IndexOf(' ') >= 0)
                throw new Exception("Error: Input number/word must not have space.");

            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            var reversedValue = new String(charArray);
            if (value == reversedValue)
            {
                isPalindromeValue = true;
            }
            else
            {
                isPalindromeValue = false;
            }
            return isPalindromeValue;
        }

        public bool IsNumber(string value)
        {
            if (value == null)
                throw new ArgumentNullException();
            bool isNumber = false;
            double dVal = 0;
            if (Double.TryParse(value, out dVal))
            {
                isNumber = true;
            }
            else
            {
                isNumber = false;
            }
            return isNumber;
        }

        public int CharacterCount(string value)
        {
            if(value ==  null)
                throw new ArgumentNullException();
            return value.Length;
        }
    }
}
