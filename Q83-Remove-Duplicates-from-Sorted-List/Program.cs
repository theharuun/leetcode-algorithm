using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q83_Remove_Duplicates_from_Sorted_List
{
    internal class Program
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            public ListNode DeleteDuplicates(ListNode head)
            {
                /*

                  while (head != null)
                  {
                      if(head.val==head.next.val)
                    {
                      head.next = head.next.next;

                      Console.WriteLine(head.val +"  "+ head.next.val + " " + head.next.next.val);
                    }
                  }

                  */

                // RemoveDuplicates
                ListNode node = head;
                while (node.next != null)
                {
                    if (node.val != node.next.val)
                    {
                        node = node.next;
                    }
                    else
                    {
                        node.next = node.next.next;
                    }
                }


                //display 
                ListNode current = head;
                while (current != null)
                {
                    Console.Write(current.val + " ");
                    current = current.next;
                }
                Console.WriteLine();

                return head;

            }
            static void Main(string[] args)
            {
                ListNode listNode = new ListNode();
                listNode.val = 1;
                listNode.next = new ListNode(1);
                listNode.next.next = new ListNode(2);
                listNode.next.next.next = new ListNode(3);
                listNode.next.next.next.next = new ListNode(3);

                Solution solution = new Solution();
                solution.DeleteDuplicates(listNode);

                Console.ReadLine();
            }
        }
    }
}
