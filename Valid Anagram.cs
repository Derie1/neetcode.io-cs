using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neetcode.io
{
    internal class ValidAnagram
    {

        
        public bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length) { return false; }

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
