using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.LinkedList
{
    public class RemoveNthNodeFromEndofList
    {
        //Definition for singly-linked list.
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

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int countList = countListNode(head);
            ListNode temp = new ListNode();
            /*ListNode fromList = new ListNode();
            ListNode endList = new ListNode();*/
            temp = removeElem(countList, n, 0, head, new ListNode());
            

            return temp;
        }

        public static ListNode removeElem(int count, int n, int i, ListNode list, ListNode temp)
        {
            i++;
            if (count - n == i)
                return removeElem(count, n, i, list.next, new ListNode());
            else if(count >= i)
            {
                temp.val = list.val;
                temp.next = removeElem(count, n, i, list.next, new ListNode());
            }
            return temp;
        }

        public static int countListNode(ListNode head, int val = 0)
        {
            val++;
            if (head.next != null)
                return countListNode(head.next,val);
            else
                return val;
        }

    }
}
