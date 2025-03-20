using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q88_Merge_Sorted_Array
{
    internal class Program
    {
        public class Solution
        {
            public void Merge(int[] nums1, int m, int[] nums2, int n)
            {
                 // basit anlaşılabilir bir kod c# hazır kodlarından (sort) faydalanmak lazım amerikayı yeniden keşfetmeye ne gerek var
                int[] yeni= new int[m+n];
                for(int i=0; i<yeni.Length;i++)
                {
                    if(i<m)
                    {
                        yeni[i] = nums1[i];
                    }
                    else
                    {
                        yeni[i] = nums2[i-m];
                    }

                }
                Array.Sort(yeni);
                for (int i = 0; i < yeni.Length; i++)
                {
                    Console.Write(yeni[i] +",");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine("**********1*************");
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            s.Merge(nums1, 3, nums2, 3);
            Console.WriteLine("**********2*************");
            int[] nums3 = { 1};
            int[] nums4 = {  };
            s.Merge(nums3,1, nums4, 0);
            Console.WriteLine("**********3*************");
            int[] nums6 = { 1 };
            int[] nums5 = { 0 };
            s.Merge(nums5, 0, nums6, 1);
            Console.ReadLine();
        }
    }
}
