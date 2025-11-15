using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PlatonovMV.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            string output = "";

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

                
                output += value.ToString().Replace(".", ",");

                
                if (x != stopValue)
                {
                    output += "\n";
                }
            }

            File.WriteAllText(path, output);
            return path;
        }
    }
}
