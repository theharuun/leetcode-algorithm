using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q242_Valid_Anagram
{
    internal class Program
    {
        public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                if (s.Length != t.Length)
                    return false;

                ArrayList firstLetters = new ArrayList();
                foreach (char c in s)
                {
                    firstLetters.Add(c);
                }

                foreach (char c in t)
                {
                    if (firstLetters.Contains(c))
                    {
                        firstLetters.Remove(c);
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }

        }

        static void Main(string[] args)
        {
            Solution so = new Solution();
          
            bool result= so.IsAnagram("anagram", "nagaram");
         
            Console.WriteLine(result);
          
            Console.ReadLine();
        }
    }
}
