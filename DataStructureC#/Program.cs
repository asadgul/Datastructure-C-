// See https://aka.ms/new-console-template for more information
using DataStructureC_.LinkedListImplemenation;
Console.WriteLine("Single Linked List");
LinkedList linkedList=new LinkedList();
Console.WriteLine("Going to create new nodes");
linkedList.AddNodeHead(1);
linkedList.AddNodeHead(2);
linkedList.AddNodeHead(3);
linkedList.AddNodeHead(4);
linkedList.AddNodeHead(5);
linkedList.AddNodeTail(6);
linkedList.AddNodeTail(7);
linkedList.AddNodeTail(8);
linkedList.AddNodeTail(9);
LinkedList linkedList2 = new LinkedList();
linkedList2.AddNodeHead(1);
linkedList2.AddNodeHead(2);
linkedList2.AddNodeHead(3);
linkedList2.AddNodeHead(4);
linkedList2.AddNodeHead(5);
linkedList2.AddNodeTail(6);
linkedList2.AddNodeTail(7);
linkedList2.AddNodeTail(8);
linkedList2.AddNodeTail(9);
linkedList.CompareLists(linkedList, linkedList2);
linkedList.NodeInsertMiddle(15,5);
linkedList.Display();
Console.WriteLine("Going to Remove  nodes");
linkedList.RemoveHead();
linkedList.RemoveTail();
linkedList.RemoveMiddleNode(3);
linkedList.Display();
Console.WriteLine("Going to Reverse Linked List");
linkedList.reversePrint(linkedList.Head);
linkedList.ReverseLinkList(linkedList);
linkedList.Display();

Console.WriteLine("Going to Validate Link List Palindrome");
LinkedList linkedList1 = new LinkedList();  
linkedList1.AddNodeHead(1);
linkedList1.AddNodeHead(2);
linkedList1.AddNodeHead(3);
linkedList1.AddNodeHead(1);
linkedList.ValidateLinkListPalindrome(linkedList1);

Console.WriteLine("Going to Merge Two Link List");
LinkedList linkedList3 = new LinkedList();
LinkedList linkedList4 = new LinkedList();
for (int i=1;i<=5;i+=2)
{
    linkedList3.AddNodeTail(i);
}
for (int i = 6; i <= 12; i += 2)
{
    linkedList4.AddNodeTail(i);
}
Console.WriteLine("1st Link List");
linkedList3.Display();
Console.WriteLine("2nd Link List");
linkedList4.Display();
LinkedList mergelist = LinkedList.MergeLinkList(linkedList3, linkedList4);

Console.WriteLine("After Merge Link List");
mergelist.Display();
Console.ReadLine();
