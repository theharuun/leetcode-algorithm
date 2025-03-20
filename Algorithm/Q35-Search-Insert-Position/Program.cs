using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q35_Search_Insert_Position
{


    internal class Program
    {
        public class Solution
        {
            public int SearchInsert(int[] nums, int target)
            {//  Input: nums = [1,3,5,6], target = 5
                for (int i=0;i<=nums.Length;i++) 
                {
                    for(int k = 0; k <= nums.Length; k++)
                    {
                        if (target > nums[i]  && target < nums[k])
                        {
                            return (k - i);

                        }
                        else if (target == nums[i])
                        {
                            return i;

                        }
                        else if(target == nums[k])
                        {
                            return k;   
                        }
                        else if (target > nums[nums.Length - 1])
                        { // burada bu if cümlesiyle kurmamız gerekiyor çünkü eğer diyelim ki target nums[k] dan büyüktür gibi bir şey alırsak ilk denenmesinde hata verirdi 
                            return nums.Length;
                        }

                    }

                }
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int []nums = {1, 3, 5, 6};
           
            s.SearchInsert(nums, 5);  // output=2

            /*
             Example 1:

                Input: nums = [1,3,5,6], target = 5
                Output: 2
                Example 2:  

                Input: nums = [1,3,5,6], target = 2
                Output: 1
                Example 3:

                Input: nums = [1,3,5,6], target = 7
                Output: 4

             */

            Console.ReadLine();

        }
    }
}
