using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q191_Number_of_1_Bits
{
    internal class Program
    {

        /*
         Example 1:

                Input: n = 11

                Output: 3

                Explanation:

                The input binary string 1011 has a total of three set bits.   how many are there 1 in binary string  ==> 3 
        */
        public class Solution
        {
            public int HammingWeight(int n)
            {
                ArrayList arrayList = new ArrayList();


                while (n > 0) // while n is bigger than 0 , this blok is running
                {
                    if (n % 2 == 1) // if n mod 2 equals to 1 , add to 1 arraylist and the new value of n is division of 2 
                    {
                        arrayList.Add(1);
                        n = (int)(n / 2);
                    }
                    else // if n mod 2 equals to 0 , the new value of n is division of 2
                    {
                       
                        n = (int)(n / 2);
                    }
                }
                 return   arrayList.Count ; // return how many are there number in arraylist 

            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int a= s.HammingWeight(11);
            Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
