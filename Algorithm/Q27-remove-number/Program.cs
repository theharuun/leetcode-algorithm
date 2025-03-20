using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14_longest_common_prefix
{
    internal class Program
    {
        public class Solution
        {
            public int removeElement(int[] nums, int val)
            {

                int index = 0;



                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != val)
                    {
                        nums[index] = nums[i];
                        index++;

                    }
                    else
                    {
                        nums[index] = -1;
                        index++;
                    }

                }
                int n = nums.Length;
                for (int i = 0; i < n - 1; i++)
                    for (int j = 0; j < n - i - 1; j++)
                        if (nums[j] > nums[j + 1])
                        {
                            var tempVar = nums[j];
                            nums[j] = nums[j + 1];
                            nums[j + 1] = tempVar;
                        }


                return index;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] ar = { 0, 1, 2, 2, 3, 0, 4, 2 };
            s.removeElement(ar, 2);

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }






            Console.ReadLine();
        }
    }
}
