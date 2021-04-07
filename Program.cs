using System;

using System.Linq;
using prova_paradigma.Entities;
using prova_paradigma.Utils;

namespace prova_paradigma
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new (string, String)[] { ("A", "B"), ("A", "C"), ("B", "G"), ("C", "H"), ("E", "F"), ("B", "D"), ("C", "E") };
            array = array.OrderBy(x => x.Item1).ToArray();
            BTree tree = new BTree();
            foreach (var node in array)
            {
                tree.Add(node.Item1,node.Item2);
            }

            Console.WriteLine(TreePrinter.MaxDepth(tree.Root.Right));

        }

    }
}
