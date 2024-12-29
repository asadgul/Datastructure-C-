// See https://aka.ms/new-console-template for more information
using DataStructureC_;

TextWriter textWriter = new StreamWriter(@"D:\NodesLinkList\testfile.txt", true);

int t = Convert.ToInt32(Console.ReadLine());

for (int tItr = 0; tItr < t; tItr++)
{
    DoublyLinkedList llist = new DoublyLinkedList();

    int llistCount = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < llistCount; i++)
    {
        int llistItem = Convert.ToInt32(Console.ReadLine());
        llist.InsertNode(llistItem);
    }

    int data = Convert.ToInt32(Console.ReadLine());

    DoublyLinkedListNode llist1 = NodesCreation.sortedInsert(llist.head, data);

   NodesCreation.PrintDoublyLinkedList(llist1, " ", textWriter);
    textWriter.WriteLine();
}

textWriter.Flush();
textWriter.Close();
//