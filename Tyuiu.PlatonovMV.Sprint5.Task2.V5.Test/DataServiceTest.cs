using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.PlatonovMV.Sprint5.Task2.V5.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            int[,] matrix = new int[3, 3]
            {
                { 9, 6, 6 },
                { 8, 7, 2 },
                { 1, 7, 8 }
            };

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);
        }
    }
}
