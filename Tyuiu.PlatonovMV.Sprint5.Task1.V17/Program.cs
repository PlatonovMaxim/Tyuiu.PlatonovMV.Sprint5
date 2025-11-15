using System;
using Tyuiu.PlatonovMV.Sprint5.Task1.V17.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Платонов М. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = 2x - 4 + (2x-1)/(sin(x)+1). Произвести табулирование*");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. Проверить деление на ноль. При делении  *");
            Console.WriteLine("* на ноль вернуть 0. Результат сохранить в файл и вывести в таблицу.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(startValue, stopValue);

            
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    x     |   F(x)   |");
            Console.WriteLine("+----------+----------+");

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 1;
                double value;

                if (Math.Abs(denominator) < 0.0001)
                {
                    value = 0;
                }
                else
                {
                    value = 2 * x - 4 + (2 * x - 1) / denominator;
                }

                value = Math.Round(value, 2);
                Console.WriteLine($"| {x,8} | {value,8} |");
            }
            Console.WriteLine("+----------+----------+");

            Console.WriteLine("Файл сохранен по пути: " + path);
            Console.ReadKey();
        }
    }
}

