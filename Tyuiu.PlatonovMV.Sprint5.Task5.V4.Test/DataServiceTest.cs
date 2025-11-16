using System;
using System.Globalization;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint5.Task5.V4.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_ProductOfNumbers()
        {
            string tempFile = Path.GetTempFileName();

            string data = "-7.95 16.41 19 11 10.92 -4 -4.39 9.89 13 8 8 -10 -1 9.9 -3.01 12.35 -4 -7.28 -4.57 -8";
            File.WriteAllText(tempFile, data);

            var ds = new DataService();
            double actual = ds.LoadFromDataFile(tempFile);

            double[] nums =
            {
                -7.95, 16.41, 19, 11, 10.92, -4, -4.39, 9.89, 13, 8,
                8, -10, -1, 9.9, -3.01, 12.35, -4, -7.28, -4.57, -8
            };

            double prod = 1.0;
            foreach (double x in nums) prod *= x;
            double expected = Math.Round(prod, 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
