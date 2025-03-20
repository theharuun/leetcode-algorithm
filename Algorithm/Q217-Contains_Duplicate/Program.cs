using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q217_Contains_Duplicate
{
    internal class Program
    {
        public class Solution
        {
            public bool ContainsDuplicate(int[] nums)
            {
                int count = 0;
                for (int i = 0; i < nums.Length / 2; i++)
                {
                    for (int j = nums.Length / 2; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            count++;
                        }
                    }
                }

                return count > 0 ? true : false;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int [] nums = { 1, 2, 3,1 };

            Console.WriteLine( s.ContainsDuplicate(nums) );
          

            Console.ReadLine();
        }
    }
}
