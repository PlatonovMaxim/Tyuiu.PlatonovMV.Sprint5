using System;
using System.IO;
using Tyuiu.PlatonovMV.Sprint5.Task6.V11.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Платонов М. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask6V11.txt, в котором есть     *");
            Console.WriteLine("* набор символьных данных. Найти количество слов длиной шесть символов    *");
            Console.WriteLine("* в заданной строке.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V11.txt";
            Console.WriteLine("Путь к входному файлу:");
            Console.WriteLine(path);
            Console.WriteLine();
            Console.WriteLine("Содержимое файла:");

            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("Файл не найден по указанному пути.");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (File.Exists(path))
            {
                DataService ds = new DataService();
                int result = ds.LoadFromDataFile(path);
                Console.WriteLine("Количество слов длиной 6 символов: " + result);
            }

            Console.ReadKey();
        }
    }
}