using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q58__length_of_the_last_world
{
    internal class Program
    {
        public class Solution
        {
            public int LengthOfLastWord(string s)
            {
                int count = 0;
                string sWithnessSpace = s.Trim();
                for (int i = sWithnessSpace.Length - 1; i >= 0; i--)
                {
                    if (sWithnessSpace[i] != ' ')
                    {
                        count++;
                    }
                    if (sWithnessSpace[i] == ' ')
                    {
                        break;
                    }
                }
                Console.WriteLine(count);
                return count;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.LengthOfLastWord(" Hello world ");
            Console.ReadLine();
        }
    }
}



  