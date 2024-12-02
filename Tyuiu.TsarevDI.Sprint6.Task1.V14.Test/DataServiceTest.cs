using Tyuiu.TsarevDI.Sprint6.Task1.V14.Lib;
namespace Tyuiu.TsarevDI.Sprint6.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue, stopValue;
            startValue = -5;
            stopValue = 5;
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            valueArray[0] = -2.15;
            valueArray[1] = -2.57;
            valueArray[2] = -3;
            valueArray[3] = -3.83;
            valueArray[4] = -11.7;
            valueArray[5] = 3;
            valueArray[6] = 2.19;
            valueArray[7] = 3.31;
            valueArray[8] = 2.97;
            valueArray[9] = 1.18;
            valueArray[10] = 0.03;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueArray, res);
        }
    }
}