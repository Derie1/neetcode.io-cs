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
            if (s.Length != t.Length) return false;
            if (s == t) return true;

            Dictionary<char, int> sCounts = new Dictionary<char, int>();
            Dictionary<char, int> tCounts = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                sCounts[s[i]] = 1 + (sCounts.ContainsKey(s[i]) ? sCounts[s[i]] : 0);
                tCounts[t[i]] = 1 + (tCounts.ContainsKey(t[i]) ? tCounts[t[i]] : 0);
            }

            foreach (char c in sCounts.Keys)
            {
                int tCount = tCounts.ContainsKey(c) ? tCounts[c] : 0;
                if (sCounts[c] != tCount) return false;
            }
            return true;
        }
    }
}
