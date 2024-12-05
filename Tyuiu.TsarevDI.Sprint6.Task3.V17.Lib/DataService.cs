using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.TsarevDI.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] array = new int[5];
            int count = 0;
            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 3)
                    {
                        array[count++] = matrix[i, j];
                    }
                }
            }
            Array.Sort(array);
            int z = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 3)
                    {
                        matrix[i, j] = array[z++];
                    }
                }
            }
            return matrix;


        }
    }
}
