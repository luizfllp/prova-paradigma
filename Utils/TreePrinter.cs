using System;
using System.Collections.Generic;
using prova_paradigma.Entities;

namespace prova_paradigma.Utils
{
    public static class TreePrinter
    {
        public static int MaxDepth(Node node)
        {
            if (node == null)
                return 0;
            return Math.Max(MaxDepth(node.Left), MaxDepth(node.Right))+1;

        }
    }
}