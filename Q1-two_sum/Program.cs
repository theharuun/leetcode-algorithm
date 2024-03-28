using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_two_sum
{
    internal class Program
    {

        /*
         TWO SUM
         Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
         */
        class Two
        {
            public int Addd(int []arr,int target)
            {

                for(int i = 0; i < arr.Length; i++)
                {
                    for(int k = i; k < arr.Length; k++)   //k=i sayesinde aynı datayı tersten yazmadı bir kez okudu diyebiliriz ( arr[i] arr[k] )
                    {                                                                                                         //( arr[k] arr[i] şeklinde yazılmamasını sağladık)
                        if (arr[i] + arr[k] == target)
                        {
                            
                            Console.WriteLine("arr["+i+"]  -  " + "arr[" + k + "] ->" + "index are : "+i+" , "+k);
                        }
                    }
                }



                return 0;
            }
        }


        static void Main(string[] args)
        {
            int []arr = { 5, 6, 8, 9, 4 };
            Two s = new Two();
            s.Addd(arr, 13);

            Console.ReadLine();
        }
    }
}
