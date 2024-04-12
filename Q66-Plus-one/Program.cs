using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Q66_Plus_one
{
    internal class Program
    {

        /*
         public class Solution 
{
    public int[] PlusOne(int[] digits) 
        {
            
                int toplam = 0;
                int basamak=(digits.Length-1);
                for(int i=0;i<digits.Length;i++)
                {
                    while(basamak>=0)
                    {
                       toplam+= digits[i]*Convert.ToInt16( Math.Pow(10, basamak ));
                    }
                }
                toplam += 1;
                string toplamStr=toplam.ToString();
                int[] newDigits=new int[toplamStr.Length];

                for(int i=0;i<newDigits.Length;i++)
                {
                    newDigits[i] = int.Parse(toplamStr[i].ToString());
                }

                Console.WriteLine("Tam Sayının Rakamları:");
                foreach (int digit in newDigits)
                {
                    Console.WriteLine(digit);
                }


                return newDigits;
            
        }
        
}
         */

        public class Solution
        {
            public int[] PlusOne(int[] digits)
            {
                int toplam = 0;
                int basamak = digits.Length;
                int[] result = digits;
                if (digits[digits.Length-1] != 9)
                {
                    result[result.Length - 1] += 1;

                    Console.WriteLine("Tam Sayının Rakamları:");
                    foreach (int digit in result)
                    {
                        Console.Write(digit + "-");
                    }
                }
                else
                {
                    for (int i = 0; i < digits.Length; i++)
                    {
                        while (basamak >= 0)
                        {
                            toplam += digits[i] * Convert.ToInt16(Math.Pow(10, (basamak-1-i)));
                        }
                    }
                    string toplamStr = toplam.ToString();
                    int[] newDigits = new int[toplamStr.Length+1];
                    for (int i = 0; i < newDigits.Length; i++)
                    {
                        newDigits[i] = int.Parse(toplamStr[i].ToString());
                    }
                    // toplam =10 iki digits
                    Console.WriteLine("/nTam Sayının Rakamları:");
                    foreach (int digit in newDigits)
                    {
                        Console.WriteLine(digit);
                    }


                    {/*
                        result[result.Length - 2] += 1;
                        result[result.Length - 1] = 0;

                        Console.WriteLine("Tam Sayının Rakamları:");
                        foreach (int digit in result)
                        {
                            Console.Write(digit + "-");
                        }
                    */}

                }


                return digits;
            }

        
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] array = { 1, 2, 3, 4 };
            s.PlusOne(array);
            int[] array2 = {9};
            s.PlusOne(array2);
            Console.ReadLine();
        }
    }
}
