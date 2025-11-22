using System;
using System.IO;
using System.Text;
using Tyuiu.PlatonovMV.Sprint5.Task7.V24.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Платонов М. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V24.txt, в котором есть       *");
            Console.WriteLine("* набор символьных данных. Заменить все русские слова на слово \"слово\".   *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V24.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V24.txt";

            Console.WriteLine("Путь к входному файлу:");
            Console.WriteLine(path);
            Console.WriteLine();

            Console.WriteLine("Содержимое входного файла:");
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path, Encoding.UTF8));
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
                string outPath = ds.LoadDataAndSave(path);

                Console.WriteLine("Результат сохранён в файл:");
                Console.WriteLine(outPath);
                Console.WriteLine();
                Console.WriteLine("Содержимое выходного файла:");
                Console.WriteLine(File.ReadAllText(outPath, Encoding.UTF8));
            }


            Console.ReadKey();
        }
    }
}