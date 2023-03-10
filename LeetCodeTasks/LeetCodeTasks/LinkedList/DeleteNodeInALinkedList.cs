using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.LinkedList
{
    public class DeleteNodeInALinkedList
    {
        public class ListNode
        {
            public int val { get; set; }
            public ListNode next;
            public ListNode(int val)
            {
                this.val = val;
            }
        }

        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            if (node.next.next != null)
                node.next = node.next.next;
            else
                node.next = null;
        }
    }
}
