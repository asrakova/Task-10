using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class BinTree
    {
        public int data;
        public BinTree left,  //адрес левого поддерева 
                       right; //адрес правого поддерева
        private static int[] arr;
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

        public static BinTree ProdIdealTree(int size, BinTree p)
        {
            arr = new int[size];
            for (int i = 0; i<size; i++)
            {
                Console.WriteLine("Введите {0}й элемент", i+1);
                arr[i] = int.Parse(Console.ReadLine());                
            }
            int j = 0;
            return p = IdealTree(size, p, ref j, arr);
        }


        //формирование идеально-сбалансированного дерева
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

        //печать дерева по уровням
        public static void ShowTree(BinTree p, int l)
        {
            if (p != null)
            {
                BinTree.ShowTree(p.left, l + 3);//переход к левому поддереву
                for (int i = 0; i < l; i++) Console.Write(" ");
                Console.WriteLine(p.data);
                BinTree.ShowTree(p.right, l + 3);//переход к правому поддереву
            }
        }

        //формирование элемента дерева
        public static BinTree MakeBinTree(int d)
        {
            BinTree p = new BinTree(d);
            return p;
        }


        public static BinTree AddElement(BinTree p)
        {
            int[] CopyArr = new int[arr.Length];
            for (int i = 0; i<arr.Length; i++)
            {
                CopyArr[i] = arr[i];
            }
            arr = new int[CopyArr.Length + 1];
            for (int i = 0; i < CopyArr.Length; i++)
            {
                arr[i] = CopyArr[i];
            }
            Console.WriteLine("Введите элемент");
            arr[arr.Length - 1] = int.Parse(Console.ReadLine());
            int j = 0;
            p = IdealTree(arr.Length, p, ref j, arr);
            return p;
        }

    }
}
