using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureC_.LinkedListImplemenation
{
    public class Nodes
    {
        public int Data;
        public Nodes next;
        public static int size = 0;
        public Nodes(int data)
        {
            this.Data = data;
            this.next = null;
            size++;
        }

    }
}
