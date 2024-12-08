using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureC_.LinkedListImplemenation
{
    public class LinkedList
    {
        public Nodes Head;
        public void AddNodeHead(int data)
        {
            Nodes nodes = new Nodes(data);
            if (Head == null)
            {
                Head = nodes;
                return;
            }
            nodes.next = Head;
            Head = nodes;
        }
        public void AddNodeTail(int data)
        {
            Nodes nodes = new Nodes(data);
            if (Head == null)
            {
                Head = nodes;
                return;
            }
            Nodes gethead = Head;
            while (gethead.next != null)
            {
                gethead = gethead.next;
            }
            gethead.next =nodes;
        }
        public void Display()
        {
            Nodes nodes=Head;
            while (nodes!=null)
            {
                Console.WriteLine(nodes.Data);
                nodes = nodes.next;
            }
        }
        public void NodeInsertMiddle(int data,int position)
        {
            int i = 1;
            Nodes nodes = Head;
            Nodes previous = null;
            while (i<position) {
            previous = nodes;
            nodes = nodes.next;
                i++;
            }
            Nodes middlenode=new Nodes(data);
            middlenode.next = previous.next;
            previous.next = middlenode;
        }
        public void RemoveHead()
        {
            Head=Head.next;
        }
        public void RemoveTail()
        {
            Nodes nodes = Head;
            Nodes previous=null;
            while (nodes.next != null)
            {
                previous=nodes;
                nodes = nodes.next;
            }
            previous.next = null;
        }
        public void RemoveMiddleNode(int index)
        {
            Nodes nodes = Head;
            Nodes previous=null;
            int i = 1;
            while (i < index) { 
            previous = nodes;
            nodes=nodes.next;
                i++;
            }
            previous.next = nodes.next;
        }
        public void ReverseLinkList(LinkedList linked)
        {
            Nodes previous = linked.Head;
            Nodes current = linked.Head.next;
            while (current != null)
            {
                Nodes nextnode = current.next;
                current.next = previous;
                previous = current;
                current = nextnode;
            }
            linked.Head.next = null;
            linked.Head = previous;
            //Nodes previous=Head;
            //Nodes current = Head.next;
            //while (current != null) {
            //    Nodes nextnode = current.next;
            //    current.next = previous;
            //    previous = current;
            //    current = nextnode;            
            //}
            //Head.next = null;
            //Head = previous;
        }
        public  void reversePrint(Nodes nodes)
        {
            if(nodes == null)
            {
                return;
            }
            reversePrint(nodes.next);
            Console.WriteLine(nodes.Data);
        }
        public bool CompareLists(LinkedList head1, LinkedList head2)
        {
            int size1st = 0,size2nd=0;
            Nodes nodes = head1.Head;
            while (nodes != null)
            {
                size1st++;
                size2nd++;
           nodes=nodes.next;
            }
            nodes = head2.Head;
            while (nodes != null)
            {
                size1st--;
                nodes = nodes.next;
            }
            if (size1st != 0)
            {
                return false;
            }
            Nodes data = head1.Head;
            Nodes data2nd = head2.Head;
            int i = 1;
            while (i <= size2nd)
            {
                if (data.Data == data2nd.Data)
                {
                    i++;
                    data=data.next;
                    data2nd = data2nd.next;
                }
                else
                {
                    return false ;
                }
            }
            return true;

        }
       public Nodes LinklistMiddleNode(Nodes Head)
        {

            Nodes hare= Head;
            Nodes tortoise = Head;
            while(tortoise.next!=null && hare.next.next != null)
            {
                tortoise= tortoise.next;
                hare = hare.next.next;
            }
            return tortoise;
        }
        public bool ValidateLinkListPalindrome(LinkedList linkedList1)
        {
            if(linkedList1.Head==null || linkedList1.Head.next == null)
            {
                return true;
            }
           
            Nodes middle=LinklistMiddleNode(linkedList1.Head);
            Nodes secondHalf = ReverseHalf(middle.next);
            Nodes half1st = linkedList1.Head;
            while (secondHalf != null)
            {
                if (half1st.Data != secondHalf.Data)
                {
                    return false;
                }
                secondHalf = secondHalf.next;
                half1st = half1st.next;

            }
            return true;

        }
        public Nodes ReverseHalf(Nodes nodes)
        {

            Nodes previous = null;
            Nodes current = nodes;
            while (current!=null)
            {
                Nodes next=current.next;
                current.next = previous;
                previous = current;
                current=next;
            }
            return previous;
        }
        public bool ValidateCycle(Nodes nodes)
        {
            Nodes turtle = nodes;
            Nodes hare = nodes;
            while(turtle.next!=null && hare.next.next != null)
            {
                turtle=turtle.next;
                hare=hare.next.next;
                if (hare == turtle)
                {
                    return true;
                }
            }
            return false;

        }
        public static LinkedList MergeLinkList(LinkedList List1st, LinkedList List2nd)
        {

            LinkedList result = new LinkedList();
            Nodes nodes = List1st.Head;
            Nodes nodes2= List2nd.Head;
            while(nodes!=null && nodes2 != null)
            {
                if (nodes.Data < nodes2.Data)
                {
                    result.AddNodeTail(nodes.Data);
                    nodes = nodes.next;
                }
                else
                {
                    result.AddNodeTail(nodes2.Data);
                    nodes2 = nodes2.next;
                }
            }

            while (nodes != null)
            {
                result.AddNodeTail(nodes.Data);
                nodes = nodes.next;
            }
            while (nodes2 != null)
            {
                 result.AddNodeTail(nodes2.Data);
                 nodes2 = nodes2.next;
            }
            return result;
        }

    }
}
