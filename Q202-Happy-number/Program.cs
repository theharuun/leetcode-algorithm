using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q202_Happy_number
{
    internal class Program
    {
        public  class Solution
        {
            public bool IsHappy(int sayi)
            {
                List<int>nonHappyNumbers = new List<int>();

                while (sayi> 0)
                {

                    int toplam = 0;
                    while (sayi > 0)
                    {
                        int basamak = sayi % 10; // Son basamağı al
                        toplam += basamak * basamak; // toplam yeni sayımız aslında toplama her basamaktaki sayıların karelerinin toplamı ekleniyor
                        sayi /= 10; // Son basamağı kaldır
                    }

                    if(nonHappyNumbers.Contains(toplam))  // eğer NONhappynumberin icindeyse false don
                    {
                        return false;
                    }
                    else    // degilsede NONhappynumberin icinde ekle
                    {
                       nonHappyNumbers.Add(toplam);
                       
                    }


                    if (toplam == 1) //1 e eşitse true don
                    {
                        return true;
                    }


                    // false veya true donmedigi durumda yeni sayımızı bu fonksıyonların ıcıne tekrar yollamak ıcın sayıyı elde ettigimiz yeni toplama esitledik
                    sayi = toplam;
                }


                return false;
              

            }
        }
        static void Main(string[] args)
        {
           Solution solution = new Solution();
           string a= solution.IsHappy(2).ToString();
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
