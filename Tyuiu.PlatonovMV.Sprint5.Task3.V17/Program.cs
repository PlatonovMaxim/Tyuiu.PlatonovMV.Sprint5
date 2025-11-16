using System;
using System.IO;
using Tyuiu.PlatonovMV.Sprint5.Task3.V17.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Платонов М.В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 2.4x^3 + 0.4x^2 - 1.4x + 4.1.                     *");
            Console.WriteLine("* Вычислить значение при x = 3, результат сохранить в бинарный файл       *");
            Console.WriteLine("* OutPutFileTask3.bin и вывести на консоль.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);

            
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                double result = reader.ReadDouble();
                Console.WriteLine($"F({x}) = {result:F3}");
            }

            Console.WriteLine($"Файл с результатом: {path}");
        }
    }
}