using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TsarevDI.Sprint6.Task7.V16.Lib
{
    public class DataService : ISprint6Task7V16
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);


            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);

                    if (i == 4 && matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = -1;
                    }
                }
            }
            return matrix;
        }
    }
}
