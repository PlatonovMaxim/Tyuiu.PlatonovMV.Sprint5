using System;
using System.Globalization;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint5.Task4.V4.Lib;

namespace Tyuiu.PlatonovMV.Sprint5.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_WithKnownX_ReturnsExpectedValue()
        {
            string tempFile = Path.GetTempFileName();

            double x = 3.04;
            File.WriteAllText(tempFile, x.ToString(CultureInfo.InvariantCulture));

            var ds = new DataService();
            double actual = ds.LoadFromDataFile(tempFile);

            double expected = -0.764;

            Assert.AreEqual(expected, actual);
        }
    }
}
