using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicAutomation_Prabhakantha
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Please Enter a String to Evalueate or pres 1 to exit");
                string inString = Console.ReadLine();

                if (inString == "1")
                {
                    isContinue = false;
                }
                else
                {
                    PalindromesAnagrams oPalindromesAnagrams = new PalindromesAnagrams();

                    oPalindromesAnagrams.isPalindromeOrAnagramOfPalindrome(inString);                   
                }                            
                
            }            

        }       
    }
}
