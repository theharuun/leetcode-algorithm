using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q21_merge_two_sorted_lists
{
    internal class Program
    {


          public class ListNode {
               public int val;
               public ListNode next;
               public ListNode(int val=0, ListNode next=null) {
                   this.val = val;
                   this.next = next;
               }
           }
 
        public class Solution
        {
            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                // birtane birleştirilmiş node oluşturdum
                ListNode mergedddd=new ListNode();

                // bir tanede işlemleri üzerinde yapcağımız şimdiki node oluşturduk
                ListNode current=  mergedddd;

                while(list1!=null && list2!=null)//eğer nodelar boş olmadığı sürece bu döngüyü yap
                {
                    if(list1.val<list2.val)        // eğer list2'nin değeri list1'in değerinden büyükse 
                    {                              // şimdiki nodeun nextine küçük olan node getir(list1) 
                        current.next = list1;      // küçük olan yerinede küçükten sonrasını getir
                        list1 = list1.next;

                    }
                    else                           // else kısmıda ifin tersi
                    {
                        current.next = list2;
                        list2 = list2.next;
                    }                             
                    current = current.next;      // burada en son curret hep ilk sayımıza eşitlemiş olduk
                }

                          // list1 boşsa list2yi yaz değilse list1 yaz şimdikinin nextine 
                if (list1 != null)
                {
                    current.next = list1;
                }
                else
                {
                    current.next = list2;
                }
                return mergedddd;
            }
        }
        static void Main(string[] args)
        {
           
 


        
        }
    }
}
