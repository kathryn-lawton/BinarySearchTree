using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
	public class BinarySearchTree
	{
		public Node root;

		public BinarySearchTree()
		{
			root = null;
		}

		//DISPLAY============================
		public void Display()
		{
			Display(root, 0);
			Console.WriteLine();
		}

		public void Display(Node node, int level)
		{
			if(node == null)
			{
				return;
			}

			Display(node.rightChild, level + 1);
			Console.WriteLine();

			for(int i = 0; i < level; i++)
			{
				Console.WriteLine("		");
			}
			Console.WriteLine(node.data);

			Display(node.leftChild, level + 1);
		}
	
		//PREORDER==========================
		public void PreOrder()
		{
			PreOrder(root);
			Console.WriteLine();
		}

		public void PreOrder(Node node)
		{
			if(node == null)
			{
				return;
			}
			Console.WriteLine(node.data + "	");
			PreOrder(node.leftChild);
			PreOrder(node.rightChild);
		}

		//INORDER TRAVERSAL=================
		public void InOrder()
		{
			InOrder(root);
			Console.WriteLine();
		}
		
		public void InOrder(Node node)
		{
			if(node == null)
			{
				return;
			}
			InOrder(node.leftChild);
			Console.WriteLine(node.data + "	");
			InOrder(node.rightChild);
		}

		public void PostOrder()
		{
			PostOrder(root);
			Console.WriteLine();
		}

		public void PostOrder(Node node)
		{
			if(node == null)
			{
				return;
			}
			PostOrder(node.leftChild);
			PostOrder(node.rightChild);
			Console.WriteLine(node.data + " ");
		}

		//LEVEL ORDERING
		public void LevelOrder()
		{
			if(root == null)
			{
				Console.WriteLine("Tree is empty");
				return;
			}
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);

			Node node;
			while(queue.Count != 0)
			{
				node = queue.Dequeue();
				Console.WriteLine(node.data + "	");
				if(node.leftChild != null)
				{
					queue.Enqueue(node.leftChild);
				}
				if(node.rightChild != null)
				{
					queue.Enqueue(node.rightChild);
				}
			}
			Console.WriteLine();
		}

		//FIND TREE HEIGHT
		public int Height()
		{
			return Height(root);
		}

		public int Height(Node node)
		{
			if(node == null)
			{
				return 0;
			}
			int heightLeft = Height(node.leftChild);
			int heightRight = Height(node.rightChild);

			if(heightLeft > heightRight)
			{
				return 1 + heightLeft;
			}
			else
			{
				return 1 + heightRight;
			}
		}

		

		public void Add(int data)
		{
			Node newNode = new Node(data);
			newNode.data = data;
			if(root == null)
			{
				root = newNode;
			}
			else
			{
				Node current = root;
				Node parent;
				while(true)
				{
					parent = current;
					if(data < current.data)
					{
						current = current.leftChild;
						if(current == null)
						{
							parent.leftChild = newNode;
							break;
						}
					}
					else
					{
						current = current.rightChild;
						if(current == null)
						{
							parent.rightChild = newNode;
							break;
						}
					}
				}
			}
		}
	}
}
