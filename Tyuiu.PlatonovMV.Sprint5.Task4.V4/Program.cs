using System;
using Tyuiu.PlatonovMV.Sprint5.Task4.V4.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Платонов М. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask4V4.txt, в котором задано      *");
            Console.WriteLine("* вещественное значение X. Прочитать значение из файла и подставить       *");
            Console.WriteLine("* вместо X в формулу y = 0.25x / cos(x). Полученное значение округлить    *");
            Console.WriteLine("* до трёх знаков после запятой и вывести на консоль.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V4.txt";
            Console.WriteLine("Путь к входному файлу:");
            Console.WriteLine(path);
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                var ds = new DataService();
                double result = ds.LoadFromDataFile(path);
                Console.WriteLine($"Результат вычисления: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
