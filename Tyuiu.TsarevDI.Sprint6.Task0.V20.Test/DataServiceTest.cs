using Tyuiu.TsarevDI.Sprint6.Task0.V20.Lib;
namespace Tyuiu.TsarevDI.Sprint6.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            Assert.AreEqual(9.037, ds.Calculate(3));
        }
    }
}