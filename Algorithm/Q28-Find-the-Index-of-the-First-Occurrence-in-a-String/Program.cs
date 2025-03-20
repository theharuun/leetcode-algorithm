using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Q28_Find_the_Index_of_the_First_Occurrence_in_a_String.Program;

namespace Q28_Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal class Program
    {

        public class Solution
        {
            public int StrStr(string haystack, string needle)
            {
               if(needle.Length == 0) { return 0; }  // eğer needleımız yoksa return 0 verebilir 

               for(int i=0;i<=haystack.Length-needle.Length;i++)   // fonksiyonun daha az adım yapması için aranılan alandan aradığımız alanı çıkarttık
                {
                    if (haystack.Substring(i, needle.Length) == needle)   // ve sırasıyla alt string arrayleri oluşturduk eğer aradığımıza eşitse hangi indexten başladığını belirttik
                    {
                        return i;
                    }
                }



                return -1;
            }
        }
        static void Main(string[] args)
        {

            Solution solution = new Solution();

            // Example 1
            string haystack1 = "saadbutsad";
            string needle1 = "sad";
            Console.WriteLine(solution.StrStr(haystack1, needle1)); // Output: 7

            // Example 2
            string haystack2 = "leetcode";
            string needle2 = "leeto";
            Console.WriteLine(solution.StrStr(haystack2, needle2)); // Output: -1

            Console.ReadLine();
        }
    }
}
