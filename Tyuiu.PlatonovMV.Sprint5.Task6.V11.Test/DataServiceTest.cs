using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.PlatonovMV.Sprint5.Task6.V11.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V11.txt";

            DataService ds = new DataService();
            int res = ds.LoadFromDataFile(path);

            Assert.IsTrue(res >= 0);
        }
    }
}