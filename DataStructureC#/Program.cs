// See https://aka.ms/new-console-template for more information
using DataStructureC_;

Console.WriteLine("Going To Create Double Linked List Nodes");
DoubleLinkList doubleLinkList = new DoubleLinkList();
Console.WriteLine("Going To Create Double Linked List Tail Nodes");
for (int i = 1; i <= 5; i++)
{
    doubleLinkList.InsertNode(i);
}
doubleLinkList.DisplayNodes();
DoubleLinkList doubleLinkListnoded = new DoubleLinkList();
Console.WriteLine("Going To Create Double Linked List Head Nodes");
for (int i = 1; i <= 7; i++)
{
    doubleLinkListnoded.InsertNodeHead(i);
}
doubleLinkListnoded.DisplayNodes();
int postion = 4;
Console.WriteLine($"Going To Insert Middle Node at position {postion}");
doubleLinkListnoded.InsertMiddleNode(12, postion);
doubleLinkListnoded.DisplayNodes();
Console.WriteLine("Going To Delete Double Linked List Head Nodes");
doubleLinkListnoded.DeleteHeadNode();
doubleLinkListnoded.DisplayNodes();
Console.WriteLine("Going To Delete Double Linked List Tail Nodes");
doubleLinkListnoded.DeleteTailNode();
doubleLinkListnoded.DisplayNodes();
Console.WriteLine("Going To Delete Double Linked List Middle Nodes");
doubleLinkListnoded.DeleteMiddleNode(3);
doubleLinkListnoded.DisplayNodes();
Console.WriteLine("Going To Print Double Link List reverse");
doubleLinkListnoded.DoubleLinkListPrintReverse();
Console.WriteLine("Going To Reverse Double Link List");
doubleLinkListnoded.ReverseDoubleLinkList();
doubleLinkListnoded.DisplayNodes();
DoubleLinkList sorted = new DoubleLinkList();
Console.WriteLine("Going To Insert Double Linked List Sorted Nodes");
//for (int i = 1; i <= 7; i++)
//{
//    if (i != 4)
//    {
//        sorted.InsertNode(i);
//    }
//}
sorted.InsertNode(1);
sorted.InsertNode(3);
sorted.InsertNode(4);
sorted.InsertNode(10);

sorted.InsertNodeSorted(sorted.Head,5);
sorted.DisplayNodes();
Console.ReadLine();