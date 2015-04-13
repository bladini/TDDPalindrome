using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCLib
{
    public class PalindromeValidator
    {
        public string ValidateValue(string value)
        {
            string retString = string.Empty;
            try
            {
                PalindromeFinder p = new PalindromeFinder();
                if (p.IsPalindrome(value))
                {
                    int count = p.CharacterCount(value);
                    string numString = p.IsNumber(value) ?
                        string.Format("it is {0} digits number.", count) :
                        string.Format("it is {0} characters word.", count);
                    retString = "Value is Palindrome and " + numString;
                }
                else
                {
                    retString = "Value is not Palindrome.";
                }
            }
            catch (Exception ex)
            {
                retString = ex.Message;
            }
            return retString;
        }
    }
}
