using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q171_Excel_Sheet_Column_Number
{
    internal class Program
    {

        public class Solution
        {
            public int TitleToNumber(string columnTitle)
            {
                Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
               
                char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

                for (int i = 0; i < alphabet.Length; i++)
                {
                    keyValuePairs.Add(i + 1, alphabet[i].ToString());
                }

                char[] column=columnTitle.ToCharArray();
               
                int key = 0; 

                double Numbase = 26;

                if (column.Length != 0)
                {
                    for (int i = 0; i < column.Length; i++)
                    {
                        foreach (var pair in keyValuePairs)
                        {
                            if (pair.Value == column[i].ToString())
                            {

                                double pow = column.Length - 1 - i;
                                key += (int)(pair.Key * Math.Pow(Numbase, pow));

                                break;
                            }
                        }
                    }
                }
                return key;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine("Excel sheet colum number converter please write column as a string");
            string ColumnTitle=Console.ReadLine();
            int x=  s.TitleToNumber(ColumnTitle.ToUpper());
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
