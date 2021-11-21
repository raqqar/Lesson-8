using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lesson_8__2_
{
    //Программно создайте текстовый файл и запишите в него 10 случайных чисел.
    //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random();
            //Программно создаём текстовый файл
            string path = "File.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();///Освобождаем поток
            }
            //Записываем в него 10 случайных чисел
            using (StreamWriter strwr = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    double num = Convert.ToInt32(rand.Next());
                    strwr.WriteLine(num);
                    Console.WriteLine(num);
                }

            }
            //Получаем массив значений
            double Summa = 0;
            string[] strNum;
            using (StreamReader strArray = new StreamReader(path))
            {
                while (!strArray.EndOfStream)
                {
                    strNum = strArray.ReadLine().Split();
                    foreach (string a in strNum)
                    {
                        if (a != null)
                        {
                            Summa += double.Parse(a);
                            
                        }
                    }
                }
            }
            Console.WriteLine("Сумма ={0} ",Summa.ToString());
            Console.ReadKey();
        }
    }
}
