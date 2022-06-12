using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosAndSamples
{
	public class LL_Node: Node
	{
		public LL_Node(int d)
		{
			data = d;
			next = null;
		}
	}
	/// <summary>
	/// Use following to run this program.cs:
	/// HR_LinkedList_Solution linkedList = new HR_LinkedList_Solution();
	///	linkedList.AddNodes();
	/// </summary>
	public class Hr_LinkedList_Solution
	{
		public void AddNodes()
		{
			LL_Node head = null;
			int T = Convert.ToInt32(Console.ReadLine());
			while(T-- > 0)
			{
				int data = Int32.Parse(Console.ReadLine());
				head = Insert(head, data);
			}
			DisplayNodes(head);
		}
		public LL_Node Insert(LL_Node head, int data)
		{
			if (head == null)
			{
				head = new LL_Node(data);
			}
			else
			{
				LL_Node n = head;
				while(n != null)
				{
					if (n.next == null) { n.next = new LL_Node(data); break; }
					else n = (LL_Node)n.next;
				}
			}
			return head;
		}
		public void DisplayNodes(LL_Node head)
		{
			LL_Node start = head;
			while(start != null)
			{
				Console.Write(start.data + " ");
				start = (LL_Node)start.next;
			}
		}
	}
}
