using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TsarevDI.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] m = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
                if ((Math.Cos(x) + x) != 0)
                {
                    m[count] = Math.Round(((((2 * x) + 6) / (Math.Cos(x) + x)) - 3), 2);
                    count++;
                }
                else
                {
                    m[count] = -3;
                    count++;
                }
            return m;
        }
    }
}
