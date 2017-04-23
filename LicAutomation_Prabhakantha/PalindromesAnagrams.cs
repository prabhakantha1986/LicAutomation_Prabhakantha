using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicAutomation_Prabhakantha
{
    public class PalindromesAnagrams
    {
        public bool isPalindromeOrAnagramOfPalindrome(string inString)
        {
            Console.Clear();

            if (isPalindrome(inString))
            {
                Console.WriteLine("The input string \"{0}\" is a Palindrome", inString);
                return true;
            }
            if (IsPalindromeAnagram(inString))
            {
                Console.WriteLine("The input string \"{0}\" is an Anagram of a Palindrome", inString);
                return true;
            }

            Console.WriteLine("The input string \" {0} \" is not a Palindrome or Anagram of a Palindrome", inString);
            return false;

        }

        public static bool IsPalindromeAnagram(string inString)
        {
            var charCount = inString.GroupBy(c => c, (c, i) => new
            {
                character = c,
                count = i.Count()
            });

            return charCount.Count(c => c.count % 2 == 1) <= 1;
        }

        public static bool isPalindrome(string inString)
        {
            return inString.SequenceEqual(inString.Reverse());
        }
    }
}
