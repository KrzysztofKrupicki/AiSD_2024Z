using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

namespace bst_23_10
{
    internal static class Program
    {
        // Drzewo binarne BST
        
        static void Main(string[] args)
        {
            Tree myTree = new Tree();
            myTree.Add(5);
            myTree.Add(2);
            myTree.Add(3);
            myTree.Add(8);
            myTree.Add(4);
            myTree.Add(1);
            myTree.Add(2);
            Console.WriteLine("\nPreOrder");
            myTree.PreOrder(myTree.root);
            Console.WriteLine("\nInOrder");
            myTree.InOrder(myTree.root);
            Console.WriteLine("\nPostOrder");
            myTree.PostOrder(myTree.root);
            Console.WriteLine("\nDrzewo początkowe");
            myTree.PrintTree(myTree.root);
            myTree.Remove(1);
            Console.WriteLine("Drzewo po usunięciu 1");
            myTree.PrintTree(myTree.root);
            myTree.Remove(2);
            Console.WriteLine("Drzewo po usunięciu 2");
            myTree.PrintTree(myTree.root);
            myTree.Remove(3);
            Console.WriteLine("Drzewo po usunięciu 3");
            myTree.PrintTree(myTree.root);
        }
    }
}