using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureC_
{
    public class NodesDoubleLinkList
    {
        public NodesDoubleLinkList next;
        public int data;
        public NodesDoubleLinkList previous;
        public NodesDoubleLinkList(int data)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }
    }
}
