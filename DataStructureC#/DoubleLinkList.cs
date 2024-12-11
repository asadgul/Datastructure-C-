using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureC_
{
    public class DoubleLinkList
    {
        public NodesDoubleLinkList Head,Tail;
        public void InsertNode(int data)
        {
            NodesDoubleLinkList newnode=new NodesDoubleLinkList(data);
            if (Head == null)
            {
                newnode.next = Head;
                Head =Tail= newnode;
                return;
            }
            NodesDoubleLinkList nodeTail = Tail;
            nodeTail.next = newnode;
            newnode.previous = nodeTail;
            Tail = newnode;
        }
        public void InsertNodeHead(int data)
        {
            NodesDoubleLinkList newnode = new NodesDoubleLinkList(data);
            if (Head == null)
            {
                newnode.next = Head;
                Head = Tail = newnode;
                return;
            }
            NodesDoubleLinkList nodeHead = Head;
            newnode.next = nodeHead;
            nodeHead.previous = newnode;
            Head = newnode;

        }

        public void DisplayNodes()
        {
            NodesDoubleLinkList nodeHead = Head;
            while (nodeHead != null)
            {
                Console.WriteLine(nodeHead.data);
                nodeHead = nodeHead.next;
            }
        }
        public void InsertMiddleNode(int data,int position)
        {
            NodesDoubleLinkList middlenode=new NodesDoubleLinkList(data);
            int i = 1;
            NodesDoubleLinkList nodeHead = Head;
            while (i < position)
            {
                nodeHead = nodeHead.next;
                i++;
            }
            middlenode.next = nodeHead;
            middlenode.previous=nodeHead.previous;
            nodeHead.previous.next = middlenode;
        }
        public void DeleteHeadNode()
        {
            Head=Head.next;
            Head.previous = null;
        }
        public void DeleteTailNode()
        {
           NodesDoubleLinkList tailnode = Head;
            while (tailnode.next.next != null)
            {
                tailnode = tailnode.next;
            }
            tailnode.next = null;
            Tail=tailnode;
        }
        public void DeleteMiddleNode(int position)
        {
            int i = 1;
            NodesDoubleLinkList nodesDoubleLinkList = Head;
            while (i < position) { 
                nodesDoubleLinkList=nodesDoubleLinkList.next;
                i++;
            }
            nodesDoubleLinkList.previous.next=nodesDoubleLinkList.next;
        }
        public void DoubleLinkListPrintReverse()
        {
            NodesDoubleLinkList nodesDoubleLinkList=Tail;
            while (nodesDoubleLinkList != null)
            {
                Console.WriteLine(nodesDoubleLinkList.data);
                nodesDoubleLinkList = nodesDoubleLinkList.previous;
            }
        }
        public void ReverseDoubleLinkList()
        {
            NodesDoubleLinkList current=Head;
            while (current != null) { 
            NodesDoubleLinkList next=current.next;              
                current.next=current.previous;
                current.previous = current.next;
                current =next;
            }
            current = Head;
            Head = Tail;
            Tail=current;

        }
        public NodesDoubleLinkList InsertNodeSorted(NodesDoubleLinkList head,int data)
        {
            NodesDoubleLinkList headnode = head;
            NodesDoubleLinkList newnode = new NodesDoubleLinkList(data);
            NodesDoubleLinkList previous = null;
            while (headnode.data < data)
            {
                previous = headnode;
                headnode = headnode.next;
            }
            newnode.next= previous.next;
            previous.next = newnode;
            newnode.previous = previous;
            headnode.previous= newnode;
//            headnode.previous.next = newnode;
            //  headnode.previous=newnode;
            //        headnode.previous.next=newnode;

            return head;
        }
    }
}
