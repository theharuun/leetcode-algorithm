using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_algorithm
{
    internal class Program
    {

        /*
         POLINDROME NUMBER
         Given an integer x, return true if x is a  palindrome , and false otherwise.
        */

        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                
                bool result = false;
                if (x <= 0)
                {
                    Console.WriteLine(result);
                    return false;
                }
                
                string stringNumber=x.ToString();
           

                for (int i = 0; i <= stringNumber.Length/2;  i++) 
                {
                    if (stringNumber[i] != stringNumber[(stringNumber.Length -1)- i])
                    {
                        result = false;
                    }
                    else
                    {
                      result= true;
                    }

                }

                if(result==true)
                {
                    
                    Console.WriteLine(result);
                    return true;
                }
                else
                {
                    Console.WriteLine(result);
                    return false; 
                }
               



            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.IsPalindrome(-1001);

            Console.ReadLine();
        }
    }
}
