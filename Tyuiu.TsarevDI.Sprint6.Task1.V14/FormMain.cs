using Tyuiu.TsarevDI.Sprint6.Task1.V14.Lib;
namespace Tyuiu.TsarevDI.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }
        private void textBox_StartValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox_StopValue_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBox_StartValue.Text);
                int stopStep = Convert.ToInt32(textBox_StopValue.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] m = new double[len];

                m = ds.GetMassFunction(startStep, stopStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|       X        |      f(x)     |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|     {0,4:f1}      |{1,10:f2}   |", startStep, m[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-24-1 Царёв Даниил Ильич", "!ACHTUNG!");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
