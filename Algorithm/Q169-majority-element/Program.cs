using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Q169_majority_element
{
    internal class Program
    {
        public class Solution
        {
            public static int big;
            public  int MajorityElement(int[] nums)
            {

             
                for (int i = 0;i<nums.Length;i++)
                {
                    big = nums[i];
                    {
                        for(int j=i+1;j<nums.Length;j++)
                        {
                            if (nums[j] > big)
                            {
                                big = nums[j];
                            }
                           
                        }
                    }
                }
                return big;
            }
        }

        static void Main(string[] args)
        {
            int[] nums = { 3,3,4 };
            Solution solution = new Solution();
            Console.WriteLine( solution.MajorityElement(nums));



            Console.ReadLine();
        }
    }
}
