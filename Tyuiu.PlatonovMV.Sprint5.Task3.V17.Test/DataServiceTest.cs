using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            string result = ds.SaveToFileTextData(3);

            
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 0);

            
        }
    }
}
