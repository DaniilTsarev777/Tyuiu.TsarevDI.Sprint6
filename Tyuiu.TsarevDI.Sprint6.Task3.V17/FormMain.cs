using System.Drawing.Drawing2D;
using Tyuiu.TsarevDI.Sprint6.Task3.V17.Lib;
namespace Tyuiu.TsarevDI.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        
        private void condition_Click(object sender, EventArgs e)
        {

        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] m = new int[5, 5] { {22, 32, -16, 24, 27 },
                                   { 3, -20, 24, -20, 25 },
                                   { 21, 17, -8, -19, 17 },
                                   { 8, 22, 28, 27, 19 },
                                   { 11, 20, 12, 27, 29 } };
            int[,] res = ds.Calculate(m);
            dataGridViewMatrix_TsarevDI.ColumnCount = res.GetLength(1);
            dataGridViewMatrix_TsarevDI.RowCount = res.GetLength(0);

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    dataGridViewMatrix_TsarevDI.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-24-1 Царёв Даниил Ильич", "!ACHTUNG!");
        }
    }
}
