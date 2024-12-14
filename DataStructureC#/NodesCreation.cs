using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureC_
{
    public class NodesCreation
    {
      public  static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }
     public  static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode llist, int data)
        {
            DoublyLinkedListNode newnode = new DoublyLinkedListNode(data);
            if (llist == null)
            {
                return newnode;
            }
            DoublyLinkedListNode headnode = llist;
            DoublyLinkedListNode previous = null;
            if (headnode.data > data)
            {
                newnode.next = headnode;
                headnode.prev=newnode;
                headnode=newnode;
                return headnode;
            }
            while (headnode.next!=null)
            {
                if (headnode.data < data)
                {
                    previous = headnode;
                    headnode = headnode.next;
                }
            }
            if (headnode.next == null && headnode.data<data)
            {
                headnode.next = newnode;
                newnode.prev = headnode;
                return headnode;
            }
            newnode.next = previous.next;           
            previous.next = newnode;          
            newnode.prev = previous;
            headnode.prev = newnode;
            // Returns the input list without modification; actual logic to be implemented here.
            return llist;
        }

    }
}
