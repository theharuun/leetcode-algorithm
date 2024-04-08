using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q20_Valid_Parentheses
{
    internal class Program
    {

        public class Solution
        {
            public bool IsValid(string s)
            {
                while (s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
                {
                    s = s.Replace("()", "");
                    s = s.Replace("{}", "");
                    s = s.Replace("[]", "");
                    Console.WriteLine(s);
                }
                return s.Length == 0 ? true : false;
            }

        }
        
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string a = "{}";
            s.IsValid(a);


            Console.ReadLine();

        }
    }
}
