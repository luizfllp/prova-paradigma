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

            try
            {
                (string, string)[] array = MockPrinter();

                array = OrderByParents(array);

                BTree tree = BTree.BuildTree(array);

                TreePrinter.PrintTree(tree.Root, 2, 10);
            }
            catch (Exceptions.MoreThanTwoChildException ex) { Logger.ExceptionToConsole(ex.Message); }
            catch (Exceptions.MultipleRootsException ex) { Logger.ExceptionToConsole(ex.Message); }
            catch (Exceptions.PresentCycleException ex) { Logger.ExceptionToConsole(ex.Message); }
            catch (System.Exception) { Logger.ExceptionToConsole("E4"); }
        }

        private static (string, string)[] MockPrinter()
        {
            return new (string, String)[] { ("A", "B"), ("A", "C"), ("B", "G"), ("C", "H"), ("H", "A"), ("E", "F"), ("B", "D"), ("C", "E") };
        }

        private static (string, string)[] OrderByParents((string, string)[] array)
        {
            array = array.OrderBy(x => x.Item1).ToArray();
            return array;
        }
    }
}
