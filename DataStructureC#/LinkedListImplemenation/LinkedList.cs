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
        public void ReverseLinkList()
        {

        }
    }
}
