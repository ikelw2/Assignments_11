
using System.Xml.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Solution mySol = new();

        ListNode myList = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        PrintList(myList);

        myList = mySol.ReverseList(myList);

        PrintList(myList);
    }

    static void PrintList(ListNode head)
    {
        ListNode cur = head;

        // loop until we reach the end of the list
        while (cur != null)
        {
            Console.Write(cur.val + " -> ");
            cur = cur.next; // Move to the next node
        }

        Console.WriteLine("null");
    }

} 

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
    public ListNode ReverseList(ListNode head)
    {

        ListNode prev = null;
        ListNode cur = head;
        ListNode next = null;

        while (cur != null)
        {
            // save the next node so we don't lose the link
            next = cur.next;
            // reverse the pointer direction
            cur.next = prev;

            // move prev one step forward
            prev = cur;
            // move current one step forward
            cur = next;
        }

        return prev;

    }
}