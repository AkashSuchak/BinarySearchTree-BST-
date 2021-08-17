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

            //Display Result
            Console.WriteLine("Binary Search Tree Elements ::");            
            binarySearch.Traverse(binarySearch.root);
            
        }
    }
}
