using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q203_Remove_Linked_List_Elements
{
    internal class Program
    {


        public class ListNode
        {
            public int Value;
            public ListNode Next;

            public ListNode(int value = 0, ListNode next = null)
            {
                Value = value;
                Next = next;
            }

            // Listeyi yazdırma metodu
            public void PrintList()
            {
                ListNode current = this;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

            // Belirtilen değere sahip düğümü listeden çıkarma metodu
            public void RemoveNode(ListNode head, int value)
            {
                ListNode current =head;

                
                // Head düğümünün çıkarılması durumu
                if (current != null && current.Value == value)
                {
                    if (current.Next != null)
                    {
                        current.Value = current.Next.Value;
                        current.Next = current.Next.Next;
                    }
                    return;
                }

                // Önceki düğümü takip ederek ilerleme
                while (current != null && current.Next != null)
                {
                    if (current.Next.Value == value)
                    {
                        current.Next = current.Next.Next;
                        return;
                    }
                    current = current.Next;
                }
            }
        }

      
        
           

        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(6);
            head.Next.Next.Next = new ListNode(3);
            head.Next.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next.Next = new ListNode(5);
   

            Console.WriteLine("Original List:");
            head.PrintList();

            // 2. düğümü çıkarma
            head.RemoveNode(head,6);

            Console.WriteLine("List after removing node with value 6:");
            head.PrintList();

            Console.ReadLine();
        }
    }
}
