using PalindromeCLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeFinder p = new PalindromeFinder();
            Console.Write("Enter a new word: ");
            var value =Console.ReadLine();
            try
            {
                if (p.IsPalindrome(value))
                {
                    int count= p.CharacterCount(value);
                    string numString = p.IsNumber(value) ? 
                        string.Format("it is {0} digits number.", count) : 
                        string.Format("it is {0} characters word.", count);
                    Console.WriteLine("Value is Palindrome and " + numString);
                }
                else
                {
                    Console.WriteLine("Value is not Palindrome.");
                }
            }
            catch (Exception  ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
