using LeetCodeTasks.LinkedList;
using LeetCodeTasks.StringsBlock;

namespace LeetCodeTasks
{
    class Program
    {
        public static void Main(string[] args)
        {
            RemoveNthNodeFromEndofList.ListNode list1 = new RemoveNthNodeFromEndofList.ListNode(1,
                new RemoveNthNodeFromEndofList.ListNode(2,
                new RemoveNthNodeFromEndofList.ListNode(3,
                new RemoveNthNodeFromEndofList.ListNode(4,
                new RemoveNthNodeFromEndofList.ListNode(5)))));

            RemoveNthNodeFromEndofList.ListNode l = RemoveNthNodeFromEndofList.RemoveNthFromEnd(list1,2);
            getWrite(l);
        }

        public static void getWrite(RemoveNthNodeFromEndofList.ListNode l = null)
        {
            if(l.next != null)
                Console.WriteLine(l.val);
        }
    }
}