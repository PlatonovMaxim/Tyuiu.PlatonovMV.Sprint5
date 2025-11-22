using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;
using Tyuiu.PlatonovMV.Sprint5.Task7.V24.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadDataAndSave()
        {
            string tempDir = Path.GetTempPath();
            string inPath = Path.Combine(tempDir, "InPutDataFileTask7V24_Test.txt");

            string text = "привет, world! тест123";
            File.WriteAllText(inPath, text, Encoding.UTF8);

            DataService ds = new DataService();
            string outPath = ds.LoadDataAndSave(inPath);

            string result = File.ReadAllText(outPath, Encoding.UTF8);

            Assert.IsTrue(result.Contains("слово"));
        }
    }
}