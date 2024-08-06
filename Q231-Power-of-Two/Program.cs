using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q231_Power_of_Two
{
    internal class Program
    {
        public class Solution
        {
            public bool IsPowerOfTwo(int n)
            {
                List<double> powerTwoList = new List<double>();

                for (double i = 0; i < 100; i++) 
                {
                    powerTwoList.Add(Math.Pow(2, i));
                }

                if (powerTwoList.Contains(n)) 
                {
                    Console.WriteLine("true");
                    return true;
                }
                else
                {
                    Console.WriteLine("false");
                    return false;
                }

            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.IsPowerOfTwo(10);

            Console.ReadLine();
        }
    }
}
