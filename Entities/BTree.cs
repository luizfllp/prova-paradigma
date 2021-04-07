using System;

namespace prova_paradigma.Entities
{
    public class BTree
    {
        private Node Root { get; set; }
        public void Add(string parent, string child)
        {
            if (parent == null || child == null) return;
            if (parent == child || Find(child, Root) != null) throw new Exception("Raízes multiplas");

            var parentNode = Find(parent, Root);

            if (parentNode == null)
            {
                Root = new Node(parent) {Left = new Node(child)};
            }

            if (parentNode!.Left != null)
            {
                parentNode.Left = new Node(child);
                return;
            }

            if (parentNode!.Right != null)
            {
                parentNode.Right = new Node(child);
                return;
            }

            throw new Exception("Mais de 2 filhos");

        }

        private static Node Find(string search, Node parent)
        {
            if (parent == null || search == null) return null;
            if (parent.Value == search) return parent;
            return Find(search, parent.Left) ?? Find(search, parent.Right);
        }
    }
}