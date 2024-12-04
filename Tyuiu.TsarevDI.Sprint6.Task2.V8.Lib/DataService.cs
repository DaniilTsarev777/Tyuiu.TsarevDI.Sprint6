using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TsarevDI.Sprint6.Task2.V8.Lib
{
    public class DataService : ISprint6Task2V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] m = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x+2.5 != 0)
                {
                    m[count++] = Math.Round(Math.Cos(2 * x) + (Math.Sin(x)) / (x + 2.5) + 2 * x, 2);
                }
                else
                {
                    m[count++] = 0;
                } 
            }
            return m;
        }
    }
}
