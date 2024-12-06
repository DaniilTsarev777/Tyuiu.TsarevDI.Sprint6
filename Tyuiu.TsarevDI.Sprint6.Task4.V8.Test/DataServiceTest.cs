using Tyuiu.TsarevDI.Sprint6.Task4.V8.Lib;
namespace Tyuiu.TsarevDI.Sprint6.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            string path = @"D:\Temp\OutPutFileTaskV8.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);

        }
    }
}