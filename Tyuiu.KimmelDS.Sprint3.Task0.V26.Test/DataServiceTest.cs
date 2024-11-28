using Tyuiu.KimmelDS.Sprint3.Task0.V26.Lib;

namespace Tyuiu.KimmelDS.Sprint3.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesTest()
        {
            var ds = new DataService();
            Assert.AreEqual(-15.642, ds.GetMultiplySeries(1, 9));
        }
    }
}