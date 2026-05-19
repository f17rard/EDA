using System;
using System.Collections.Generic;
using System.Text;

namespace DemoListasEnlazadas1
{
    internal class Node
    {
		//private int data;

		//public int Data
		//{
		//	get { return data; }
		//	set { data = value; }
		//}

		//private Node next;

		//public Node Next
  //      {
  //          get { return next; }
  //          set { next = value; }
  //      }

		public int Data {  get; set; }
		public Node? Next { get; set; }
        public Node(int data)
		{
			this.Data = data;
			this.Next = null;
		}
	}
}
