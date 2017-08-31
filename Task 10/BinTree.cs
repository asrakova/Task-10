using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class BinTree
    {
        public int data;            // Данные вершины
        public BinTree left,        // Адрес левого поддерева 
                       right;       // Адрес правого поддерева
        private static int[] arr;   // Вершины дерева
        public BinTree()
        {
            data = 0;
            left = null;
            right = null;
        }
        public BinTree(int d)
        {
            data = d;
            left = null;
            right = null;
        }
        public override string ToString()
        {
            return data + " ";
        }

        /// <summary>
        /// Создание сбалансированного дерева
        /// </summary>
        /// <param name="size">Количество вершин</param>
        /// <param name="tree">Дерево</param>
        /// <returns>Сбалансированное дерево</returns>
        public static BinTree ProdIdealTree(int size, BinTree tree)
        {
            // Заполнение массива
            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Введите {0}й элемент", i + 1);
                arr[i] = ReadCheak.ReadInt();
            }
            int j = 0;
            // Создание сбалансированного дерева по массиву вершин
            return IdealTree(size, tree, ref j, arr);
        }

        // Формирование идеально-сбалансированного дерева       
        private static BinTree IdealTree(int size, BinTree p, ref int i, int[] arr)
        {
            BinTree r;
            int nl, nr;
            if (size == 0) { p = null; return p; }
            nl = size / 2;
            nr = size - nl - 1;
            int d = arr[i]; i++;
            r = new BinTree(d);
            r.left = IdealTree(nl, r.left, ref i, arr);
            r.right = IdealTree(nr, r.right, ref i, arr);
            p = r;
            return p;
        }

        /// <summary>
        /// Печать дерева по уровням
        /// </summary>
        /// <param name="tree">Дерево</param>
        /// <param name="loc">Положение</param>
        public static void ShowTree(BinTree tree, int loc)
        {
            if (tree != null)
            {
                BinTree.ShowTree(tree.left, loc + 3);   // Переход к левому поддереву
                for (int i = 0; i < loc; i++) Console.Write(" ");
                Console.WriteLine(tree.data);
                BinTree.ShowTree(tree.right, loc + 3);  // Переход к правому поддереву
            }
        }

        /// <summary>
        /// Формирование элемента дерева
        /// </summary>
        /// <param name="d">Данные</param>
        /// <returns>Элемент дерева</returns>
        public static BinTree MakeBinTree(int d)
        {
            BinTree p = new BinTree(d);
            return p;
        }

        /// <summary>
        /// Добавление элемента и балансировка дерева
        /// </summary>
        /// <param name="tree">Дерево</param>
        /// <returns>Сбалансированное дерево с добавленной вершиной</returns>
        public static BinTree AddElement(BinTree tree)
        {
            // Копирование элементов дерева
            int[] CopyArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                CopyArr[i] = arr[i];
            }
            // Увеличение числа вершин в массиве
            arr = new int[CopyArr.Length + 1];
            // Возвращение элементов в массив
            for (int i = 0; i < CopyArr.Length; i++)
            {
                arr[i] = CopyArr[i];
            }
            // Добавление вершины
            Console.WriteLine("Введите элемент");
            arr[arr.Length - 1] = ReadCheak.ReadInt();
            int j = 0;
            // Сбалансирование дерева
            return IdealTree(arr.Length, tree, ref j, arr);
        }

    }
}
