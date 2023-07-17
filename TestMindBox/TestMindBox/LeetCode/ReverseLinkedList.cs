using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMindBox.LeetCode;


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


/// <summary>
/// https://leetcode.com/problems/reverse-linked-list/description/

/// </summary>
public class ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {

        #region My solution
        //if (head is null)
        //    return null;

        //if (head.next is null)
        //    return head;

        //var stack = new Stack<ListNode>();
        //while (head is not null)
        //{
        //    stack.Push(head);
        //    head = head.next;
        //}


        //head = stack.Pop();
        //head.next = new ListNode(stack.Pop().val);
        //var nextNode = head.next;
        //while (stack.TryPop(out ListNode node))
        //{
        //    nextNode.next = new ListNode(node.val);
        //    nextNode = nextNode.next;
        //}

        //return head;
        #endregion

        ListNode current = head;
        ListNode prev = null;
        ListNode next = null;
        while(current is not null) 
        {
            next = current.next;

            current.next = prev;
            prev = current;

            current = next;
        }

        return prev;
    }
}
