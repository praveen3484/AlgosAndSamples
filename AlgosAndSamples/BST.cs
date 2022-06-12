using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosAndSamples
{
	public class BST_Node : Node
	{
		public int data;
		public BST_Node left, right;
		public BST_Node(int data)
		{
			this.data = data;
			left = right = null;
		}
	}
	/// <summary>
	/// Implementation of BST.
	/// Use following to run:
	/// BST bST = new BST();
	/// bST.Run();
	/// </summary>
	public class BST
	{
		public void Run()
		{
			BST_Node root = null;
			int T = int.Parse(Console.ReadLine());
			while (T-- > 0)
			{
				int data = int.Parse(Console.ReadLine());
				root = InsertNode(root, data);
			}
			Console.WriteLine("Traversal of Given Binary Search Tree is:");
			InOrderTraverseBST(root);
			Console.WriteLine();
			BFS(root);
			int height = GetHeight(root);
			Console.WriteLine($"Height of given Binary Search Tree is: {height}");
		}
		#region Insertion to BST
		public BST_Node InsertNode(BST_Node node, int data)
		{
			if (node == null)
				return new BST_Node(data);
			else
			{
				BST_Node cur;
				if (data <= node.data)
				{
					cur = InsertNode(node.left, data);
					node.left = cur;
				}
				else
				{
					cur = InsertNode(node.right, data);
					node.right = cur;
				}
				return node;
			}
		}

		#endregion
		#region Traversal
		public void InOrderTraverseBST(BST_Node node)
		{
			if (node == null)
				return;
			else
			{
				/* first recur on left child */
				InOrderTraverseBST(node.left);
				/* then print the data of node */
				Console.Write(node.data + " ");
				/* now recur on right child */
				InOrderTraverseBST(node.right);
			}
		}
		public void PreOrderTraverseBST(BST_Node node)
		{
			if (node == null)
				return;
			else
			{
				// First print data of the node
				Console.Write(node.data + " ");
				// first recur on left subtree
				PreOrderTraverseBST(node.left);
				// now recur on right subtree
				PreOrderTraverseBST(node.right);
			}
		}
		public void PostOrderTraverseBST(BST_Node node)
		{
			if (node == null)
				return;
			else
			{
				// first recur on left subtree
				PostOrderTraverseBST(node.left);
				// then recur on right subtree
				PostOrderTraverseBST(node.right);
				// now deal with the node
				Console.Write(node.data + " ");
			}
		}

		void BFS(BST_Node node)
		{
			if (node != null)
			{
				Console.WriteLine(node.data);
				
			}
		}
		#endregion

		public int GetHeight(BST_Node root)
		{
			if (root == null || (root.left == null && root.right == null))
				return 0;
			else
			{
				return CalcHeight(root);
			}
		}

		#region Calculate Height of BST
		/// <summary>
		/// Solution 1
		/// </summary>
		/// <param name="root"></param>
		/// <returns></returns>
		public int CalcHeight(BST_Node node)
		{
			if (node == null)
				return -1;
			/* compute the depth of each subtree */
			int lDepth = CalcHeight(node.left);
			int rDepth = CalcHeight(node.right);

			/* use the larger one */
			if (lDepth > rDepth)
				return (lDepth + 1);
			else
				return (rDepth + 1);
		}

		/// <summary>
		/// Solution 2
		/// </summary>
		/// <param name="root"></param>
		/// <returns></returns>
		private int getHeight(BST_Node root)
		{
			if (root == null)
			{
				return -1;
			}
			return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
		}

		#endregion
	}
}
