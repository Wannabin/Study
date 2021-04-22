using System;
using System.Collections.Generic;

namespace AddTwoNumbers
{
    class Program
    {
        //LinkedListNode<int> LinkedListNode = new LinkedListNode<int>(0);
        
        
        public class ListNode
        {
            
            public int val; //데이터 저장 변수
            public ListNode next; //다른 노드를 참조할 링크 노드
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;

            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null)
                {
                    p = p.next;
                }
                if (q != null)
                {
                    q = q.next;
                }
            }
            if (carry>0)
            {
                curr.next = new ListNode(carry);
            }

            return dummyHead.next;
        }

        static void Main(string[] args)
        {
            ListNode test1 = new ListNode(0);

            test1.next = new ListNode(1);
            test1.next = new ListNode(2);

        }
    }
}
