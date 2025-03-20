using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q13_Roman_to_integer
{
    internal class Program
    {
        public class Solution
        {
           
                public int RomanToInt(string s)
                {
                    int res = 0;
                    int prev = 0;
                    Dictionary<char, int> romanNumerals =
                        new Dictionary<char, int>
                        {
                    {'M', 1000},
                    {'D', 500},
                    {'C', 100},
                    {'L' , 50},
                    {'X' , 10},
                    {'V' , 5},
                    {'I' , 1}
                        };
                    for (int i = s.Length - 1; i >= 0; i--)
                    {
                        if (prev <= romanNumerals[s[i]])
                        {
                            res += romanNumerals[s[i]];
                        }
                        else if (prev > romanNumerals[s[i]])
                        {
                            res -= romanNumerals[s[i]];
                        }
                        prev = romanNumerals[s[i]];
                    }
                    return res;
                }
            
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.RomanToInt("IV");


          Console.ReadLine();
        }
    }
}
