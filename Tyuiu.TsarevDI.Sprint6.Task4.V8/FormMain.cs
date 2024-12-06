using Tyuiu.TsarevDI.Sprint6.Task4.V8.Lib;
namespace Tyuiu.TsarevDI.Sprint6.Task4.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(startValue_TsarevDI.Text);
                int stopValue = Convert.ToInt32(stopValue_TsarevDI.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] m = new double[len];
                m = ds.GetMassFunction(startValue, stopValue);

                this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult.Text = "";
                chart1.Series[0].Points.Clear();
                for (int i = 0; i <= len; i++)
                {
                    this.chart1.Series[0].Points.AddXY(startValue, m[i]);
                    textBoxResult.AppendText(m[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТб-24-1 Царёв Даниил Ильич", "!ACHTUNG!");
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempFileName(), "OutPutFileTaskV8.txt");
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " успешно сохранён!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void startValue_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void stopValue_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
