using Tyuiu.TsarevDI.Sprint6.Task5.V23.Lib;
namespace Tyuiu.TsarevDI.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V23.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNums.Rows.Clear();

            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width = 20;
            dataGridViewNums.Columns[1].Width = 50;

            this.chartDiag.ChartAreas[0].AxisX.Title = "��� X";
            this.chartDiag.ChartAreas[0].AxisY.Title = "��� Y";

            chartDiag.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartDiag.Series[0].Points.AddXY(i, numMass[i]);
            }

        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 5 �������� ������� ������ ������-24-1 ���� ������ �����", "!ACHTUNG!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
