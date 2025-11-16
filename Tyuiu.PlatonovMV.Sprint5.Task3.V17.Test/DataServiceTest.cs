using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint5.Task3.V17.Lib;
using System.IO;

namespace Tyuiu.PlatonovMV.Sprint5.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;

            string path = ds.SaveToFileTextData(x);
            Assert.IsTrue(File.Exists(path));

            double expected = Math.Round(2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1, 3);

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                double result = reader.ReadDouble();
                Assert.AreEqual(expected, result);
            }
        }
    }
}