using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PlatonovMV.Sprint5.Task4.V4.Lib
{
    public class DataService : ISprint5Task4V4
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path).Trim();
            double x = double.Parse(text, CultureInfo.InvariantCulture);
            double y = 0.25 * x / Math.Cos(x);
            return Math.Round(y, 3);
        }
    }
}
