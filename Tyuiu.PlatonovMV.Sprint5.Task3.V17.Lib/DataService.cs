using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.PlatonovMV.Sprint5.Task3.V17.Lib
{
    public class DataService : ISprint5Task3V17
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            //  y = x⁴ + x³/2 + 2x² + x
            double y = Math.Pow(x, 4) + Math.Pow(x, 3) / 2 + 2 * Math.Pow(x, 2) + x;
            y = Math.Round(y, 3);

            
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            
            byte[] fileBytes = File.ReadAllBytes(path);
            string base64String = Convert.ToBase64String(fileBytes);

            return base64String;
        }
    }
}
