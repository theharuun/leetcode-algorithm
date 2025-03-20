using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q136_Single_number
{
    internal class Program
    {
        public class Solution
        {
            public int SingleNumber(int[] nums)
            {                 
                for(int i=0;i<nums.Length;i++)
                {
                    for(int k = i + 1; k < nums.Length; k++)
                    {
                        if (nums[k] == nums[i])  //eger ayni sayidan bu dizide herhangi bir indexte varsa bu if statement gir
                        {
                            Array.Clear(nums, k, 1);   // bu diziden kaldir iki indexteki aynı sayilari
                            Array.Clear((int[])nums, i, 1);
                        }
                    }
                    // bu for ya blogu bittikten sonra dizide  tek sayi ve diger sayilar yerine 0 aldi
                    // bu yüzden disariya tek sayiyi vermek için alltaki if statement kullanicaz
                    if (nums[i] != 0)
                    {
                        Console.WriteLine(nums[i]);
                        return nums[i];
                    }
                }
                return 0;   
            }

        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] number = {5,3,5,5,5,4,6,6,8,8, 4, 1, 2, 1, 2 };
            s.SingleNumber(number);
          


            Console.ReadLine();
        }
    }
}
