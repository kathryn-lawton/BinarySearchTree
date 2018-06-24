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

			for(int i = 0; i < level; i++)
			{
				Console.Write("		");
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
			if (node == null)
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
			if (node == null)
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
			if (node == null)
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
			if (root == null)
			{
				Console.WriteLine("Tree is empty");
				return;
			}
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);

			Node node;
			while (queue.Count != 0)
			{
				node = queue.Dequeue();
				Console.WriteLine(node.data + "	");
				if (node.leftChild != null)
				{
					queue.Enqueue(node.leftChild);
				}
				if (node.rightChild != null)
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
			if (node == null)
			{
				return 0;
			}
			int heightLeft = Height(node.leftChild);
			int heightRight = Height(node.rightChild);

			if (heightLeft > heightRight)
			{
				return 1 + heightLeft;
			}
			else
			{
				return 1 + heightRight;
			};
		}
		//ADD=================
		public void Add(int data)
		{
			Node newNode = new Node(data);
			if(root == null)
			{
				root = newNode;
			}
			else
			{
				Node current = root;
				while(true)
				{
					if(data < current.data)
					{
						if(current.leftChild == null)
						{
							current.leftChild = newNode;
							break;
						}
						else
						{
							current = current.leftChild;
						}
					}
					else
					{
						if(current.rightChild == null)
						{
							current.rightChild = newNode;
							break;
						}
						else
						{
							current = current.rightChild;
						}
					}
				}
			}
		}

		public void GetUserInput()
		{
			Console.WriteLine("Please enter the number you would like to find: ");
			int input = Convert.ToInt32(Console.ReadLine());
		}
		//SEARCH=====================
		public static void Search(int input, Node node)
		{
			
			if (node == null)
			{
				Console.WriteLine($"Node {input} not found.");
			}
			else if (node.data == input)
			{
				Console.WriteLine($"Node {input} is found." );
			}
			else if (input < node.data)
			{
				Search(input, node.leftChild);
			}
			else
			{
				Search(input, node.rightChild);
			}

		}
	}
}

