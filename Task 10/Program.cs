using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            BinTree Tree = new BinTree();
            Tree = BinTree.ProdIdealTree(size, Tree);
            Console.WriteLine("Сформироманый список: ");
            BinTree.ShowTree(Tree, size);

            Tree = BinTree.AddElement(Tree);
            Console.WriteLine("Сформироманый список: ");
            BinTree.ShowTree(Tree, size);
            Console.ReadLine();
        }
    }
}
