using System;
using Tyuiu.PlatonovMV.Sprint5.Task5.V4.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Платонов М. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V4.txt, в котором есть набор *");
            Console.WriteLine("* значений. Найти произведение всех вещественных чисел в файле.          *");
            Console.WriteLine("* Полученный результат округлить до трёх знаков после запятой и вывести   *");
            Console.WriteLine("* на консоль.                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V4.txt";
            Console.WriteLine("Путь к входному файлу:");
            Console.WriteLine(path);
            Console.WriteLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                var ds = new DataService();
                double result = ds.LoadFromDataFile(path);
                Console.WriteLine($"Произведение чисел: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
