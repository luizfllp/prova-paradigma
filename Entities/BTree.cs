using System;
using prova_paradigma.Exceptions;

namespace prova_paradigma.Entities
{
    public class BTree
    {
        public Node Root { get; private set; }

        public void Add(string parent, string child)
        {
            var childFound = Find(child, Root);
            if (parent == null || child == null) return;
            if (parent == child || Find(parent, childFound) != null) throw new PresentCycleException();
            if (childFound != null) throw new MultipleRootsException();

            var parentNode = Find(parent, Root);

            if (parentNode == null)
            {
                Root = new Node(parent) { Left = new Node(child) };
                return;
            }

            if (parentNode!.Left == null)
            {
                parentNode.Left = new Node(child);
                return;
            }

            if (parentNode!.Right == null)
            {
                parentNode.Right = new Node(child);
                return;
            }

            throw new MoreThanTwoChildException();
        }

        private static Node Find(string search, Node parent)
        {
            if (parent == null || search == null) return null;
            if (parent.Value == search) return parent;
            return Find(search, parent.Left) ?? Find(search, parent.Right);
        }

        public static BTree BuildTree((string, string)[] array)
        {
            BTree tree = new BTree();
            foreach (var node in array)
            {
                tree.Add(node.Item1, node.Item2);
            }

            return tree;
        }
    }
}