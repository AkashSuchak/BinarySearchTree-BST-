using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome To Binary Search Tree (BST)!");

            //Call Class
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>();

            //Display Root 
            Console.WriteLine("Root : 56 ");

            //Add Elements in Tree
            binarySearch.Insert(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);

            //Display Result
            Console.Write("\n:: BST Elements Traversal :: \n");
            binarySearch.Traverse(binarySearch.root);
            Console.WriteLine("\n--------------------------------------");
            binarySearch.SizeOfTree();

            
            
            
            
        }
    }
}
