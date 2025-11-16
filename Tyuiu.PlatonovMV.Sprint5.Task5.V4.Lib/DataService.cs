using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PlatonovMV.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] parts = text
                .Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            double product = 1.0;

            foreach (string p in parts)
            {
                double x = double.Parse(p, CultureInfo.InvariantCulture);
                product *= x;
            }

            return Math.Round(product, 3);
        }
    }
}
