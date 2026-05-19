using System;
using System.Collections.Generic;
using System.Text;

namespace DemoColas2026
{
    internal class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public Node(int _data)
        {
            this.Data = _data;
            this.Next = null;
        }
    }
}
