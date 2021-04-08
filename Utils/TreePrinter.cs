using System;
using System.Collections.Generic;
using System.Linq;
using prova_paradigma.Entities;

namespace prova_paradigma.Utils
{
    public static class TreePrinter
    {
        private static readonly string LEFT_BAR = "/";
        private static readonly string RIGHT_BAR = "\\";

        public static void PrintTree(Node node, int depth = 0, int startRow = 1, int startCol = 0)
        {
            if (node == null) return;
            if (depth == 0)
                depth = MaxDepth(node) - 1;
            var barCount = Convert.ToInt32(Math.Pow(2, depth - 1));
            var leftSpace = Convert.ToInt32(Enumerable.Range(0, depth).Select(x => Math.Pow(2, x)).Sum());


            Console.SetCursorPosition(leftSpace + startCol, startRow);
            Console.Write(node.Value);
            if (barCount > 0)
                PrintBar(barCount, leftSpace + startCol - 1, startRow + 1, node.Left != null, node.Right != null);
            PrintTree(node.Left, depth - 1, startRow + barCount + 1, startCol);
            PrintTree(node.Right, depth - 1, startRow + barCount + 1, startCol + 1 + leftSpace);
        }

        public static void PrintBar(int barCount, int startCol, int startRow, bool printLeft, bool printRight)
        {
            var spaceBetween = 0;
            for (int i = 0; i < barCount; i++)
            {
                spaceBetween += 1;
                if (printLeft)
                {
                    Console.SetCursorPosition(startCol - i, startRow + i);
                    Console.Write("/");
                }

                if (printRight)
                {
                    Console.SetCursorPosition(startCol + 1 + spaceBetween, startRow + i);
                    Console.Write("\\");
                }
            }
        }

        private static int MaxDepth(Node node)
        {
            if (node == null)
                return 0;
            return Math.Max(MaxDepth(node.Left), MaxDepth(node.Right)) + 1;
        }
    }
}