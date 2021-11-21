using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_8__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выберите любую папку на своем компьютере, имеющую вложенные директории.
            //Выведите на консоль ее содержимое и содержимое всех подкаталогов.

            //Не очень понятно условие задачи, но вроде так:

            Console.WriteLine("Введите адрес папки");
            string catalogFiles = Convert.ToString(Console.ReadLine());
            string[] catalogs = Directory.GetDirectories(catalogFiles,"*.*",SearchOption.AllDirectories);
            foreach (string a in catalogs)
            {
                Console.WriteLine(a);
                string[] files = Directory.GetFiles(a);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
