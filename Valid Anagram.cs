using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neetcode.io
{
    internal class ValidAnagram
    {
        /*Given two strings s and t, return true if t is an anagram of s, and false otherwise.

        An Anagram is a word or phrase formed by rearranging the letters of a different word or 
        phrase, typically using all the original letters exactly once. 

        Example 1:

        Input: s = "anagram", t = "nagaram"
        Output: true
        Example 2:

        Input: s = "rat", t = "car"
        Output: false
        */

        public bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length) { return false; }
            if (s == t) { return true; }

            int stringLength = s.Length;
            for (int i = 0; i < stringLength; i++)
            {
                char c = s[i];
                int indexOfChar = t.IndexOf(c);
                try { t = t.Remove(indexOfChar, 1); }
                catch { return false; }
            }
            return true;
        }
    }
}
