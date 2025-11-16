using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.PlatonovMV.Sprint5.Task3.V17.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);
        }
    }
}
