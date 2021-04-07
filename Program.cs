using System;

using System.Linq;
using prova_paradigma.Entities;

namespace prova_paradigma
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new (string, String)[] { ("A", "B"), ("A", "C"), ("B", "G"), ("C", "H"), ("E", "F"), ("B", "D"), ("C", "E") };
            BTree tree = new BTree();
            foreach (var node in array)
            {
                tree.Add(node.Item1,node.Item2);
            }
            
            Console.WriteLine("wait");
        }

    }
}
