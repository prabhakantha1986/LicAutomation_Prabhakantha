using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LicAutomation_Prabhakantha;

namespace LicAutomation_PrabhakanthaTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_anna()
        {
            string inString = "anna";
            bool expected = true;
            PalindromesAnagrams oPalindromesAnagrams = new PalindromesAnagrams();
            bool actual = oPalindromesAnagrams.isPalindromeOrAnagramOfPalindrome(inString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_aaaaaaaa()
        {
            string inString = "aaaaaaaa";
            bool expected = true;
            PalindromesAnagrams oPalindromesAnagrams = new PalindromesAnagrams();
            bool actual = oPalindromesAnagrams.isPalindromeOrAnagramOfPalindrome(inString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_aaaaaaaab()
        {
            string inString = "aaaaaaaab";
            bool expected = true;
            PalindromesAnagrams oPalindromesAnagrams = new PalindromesAnagrams();
            bool actual = oPalindromesAnagrams.isPalindromeOrAnagramOfPalindrome(inString);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_caaaaaaaab()
        {
            string inString = "caaaaaaaab";
            bool expected = false;
            PalindromesAnagrams oPalindromesAnagrams = new PalindromesAnagrams();
            bool actual = oPalindromesAnagrams.isPalindromeOrAnagramOfPalindrome(inString);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_donotbobtonod()
        {
            string inString = "donotbobtonod";
            bool expected = true;
            PalindromesAnagrams oPalindromesAnagrams = new PalindromesAnagrams();
            bool actual = oPalindromesAnagrams.isPalindromeOrAnagramOfPalindrome(inString);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_owefhijpfwai()
        {
            string inString = "owefhijpfwai";
            bool expected = false;
            PalindromesAnagrams oPalindromesAnagrams = new PalindromesAnagrams();
            bool actual = oPalindromesAnagrams.isPalindromeOrAnagramOfPalindrome(inString);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_igdedgide()
        {
            string inString = "igdedgide";
            bool expected = true;
            PalindromesAnagrams oPalindromesAnagrams = new PalindromesAnagrams();
            bool actual = oPalindromesAnagrams.isPalindromeOrAnagramOfPalindrome(inString);

            Assert.AreEqual(expected, actual);
        }
    }
}
