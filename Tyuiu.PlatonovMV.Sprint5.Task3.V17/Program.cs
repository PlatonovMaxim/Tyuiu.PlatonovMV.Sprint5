using System;
using System.IO;
using Tyuiu.PlatonovMV.Sprint5.Task3.V17.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Платонов М. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись в бинарный файл                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до  *");
            Console.WriteLine("* трёх знаков после запятой.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string base64Result = ds.SaveToFileTextData(x);

            
            double result = Math.Pow(x, 4) + Math.Pow(x, 3) / 2 + 2 * Math.Pow(x, 2) + x;
            result = Math.Round(result, 3);

            Console.WriteLine("Результат вычисления: " + result);
            Console.WriteLine("Base64 представление файла: " + base64Result);

            
            byte[] fileBytes = Convert.FromBase64String(base64Result);
            using (MemoryStream stream = new MemoryStream(fileBytes))
            using (BinaryReader reader = new BinaryReader(stream))
            {
                double valueFromBytes = reader.ReadDouble();
                Console.WriteLine("Значение из Base64: " + valueFromBytes);
            }

            Console.ReadKey();
        }
    }
}
