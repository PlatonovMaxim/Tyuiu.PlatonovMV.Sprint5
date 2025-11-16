
using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.PlatonovMV.Sprint5.Task2.V5.Lib
{
    public class DataService : ISprint5Task2V5
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            string output = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value = matrix[i, j];
                    if (value % 2 != 0)
                    {
                        value = 0;
                    }

                    output += value.ToString();

                    if (j < cols - 1)
                    {
                        output += ";";
                    }
                }

                if (i < rows - 1)
                {
                    output += "\n";
                }
            }

            File.WriteAllText(path, output);
            return path;
        }
    }
}