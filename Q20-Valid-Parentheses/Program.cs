using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
                    s = s.Replace("()", "");  // eğer açma kapama varsa sırasıyla onun yerine boşluk koyduk
                    s = s.Replace("{}", "");
                    s = s.Replace("[]", "");
                    Console.WriteLine(s);
                }                             // bütün sonuçlar bittikten sonra eğer snin boyutu 0a eşitse true dön 0dan farklıysa false dön       
                return s.Length == 0 ? true : false;
            }

        }
        
        static void Main(string[] args)
        {
            Solution s = new Solution();
            ArrayList a =new ArrayList();
            a.Add("{");
            a.Add("}");
            string b=a.ToString();
            s.IsValid(b);


            Console.ReadLine();

        }
    }
}
