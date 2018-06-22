using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Binary Search Tree:");
			BinarySearchTree tree = new BinarySearchTree();
			tree.Add(60);
			tree.Add(50);
			tree.Add(70);
			tree.Add(30);
			tree.Add(35);
			tree.Add(10);
			tree.Add(5);
			tree.Display();

			Console.WriteLine("Pre-order: ");
			tree.PreOrder();
			Console.WriteLine();

			Console.WriteLine("Post-order: ");
			tree.PostOrder();
			Console.WriteLine();

			Console.WriteLine("Level order: ");
			tree.LevelOrder();
			Console.WriteLine();

			Console.ReadLine();


			
		}
	}
}
