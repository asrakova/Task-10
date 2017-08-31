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
            // Создание дерева
            Console.WriteLine("Введите количество вершин дерева");
            int size = ReadCheak.ReadPositve();
            BinTree Tree = new BinTree();
            Tree = BinTree.ProdIdealTree(size, Tree);
            // Вывод дерева
            Console.WriteLine("Сформированый список: ");
            BinTree.ShowTree(Tree, size);

            // Добавление вершин
            Console.WriteLine("Добавление элементов:");
            Console.WriteLine("Введите количество добавляемых вершин");
            int NumAdd = ReadCheak.ReadPositve();
            for (int i = 1; i <= NumAdd; i++)
            {
                Tree = BinTree.AddElement(Tree);
                Console.WriteLine("Сформированый список: ");
                BinTree.ShowTree(Tree, size);
            }
            Console.ReadLine();
        }
    }
}
