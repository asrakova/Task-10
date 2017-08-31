using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class ReadCheak
    {
        /// <summary>
        /// Проверка ввода целых чисел
        /// </summary>
        /// <returns>Целое число</returns>
        public static int ReadInt()
        {
            int k = 0; bool ok;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out k);
                if (!ok) Console.WriteLine("Неправильный ввод. Ожидалось целое число. Пожалуйста, повторите ввод");
            }
            while (!ok);

            return k;
        }

        /// <summary>
        /// Проверка ввода натуральных чисел
        /// </summary>
        /// <returns>Натуральное число</returns>
        public static int ReadPositve()
        {
            int k = 0; bool ok;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out k);
                if (!ok || k <= 0) Console.WriteLine("Неправильный ввод. Ожидалось натуральное число. Пожалуйста, повторите ввод");
            }
            while (!ok || k <= 0);
            return k;
        }
    }
}
