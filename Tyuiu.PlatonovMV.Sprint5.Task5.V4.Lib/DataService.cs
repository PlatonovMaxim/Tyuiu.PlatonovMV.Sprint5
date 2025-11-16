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

            double res = 1.0;
            bool hasAny = false;

            foreach (string p in parts)
            {
                double x = double.Parse(p, CultureInfo.InvariantCulture);

                
                if (x % 1 != 0)
                {
                    res *= x;
                    hasAny = true;
                }
            }

            if (!hasAny)
                return 0;

            return Math.Round(res, 3);
        }
    }
}
