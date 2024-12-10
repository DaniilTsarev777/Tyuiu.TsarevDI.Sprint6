using Tyuiu.TsarevDI.Sprint6.Task6.V19.Lib;
namespace Tyuiu.TsarevDI.Sprint6.Task6.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_TD_Click(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string str = "l";
            textBoxResult.Text = ds.CollectTextFromFile(str, openFilePath);
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void openFileDialog_TD_Click(object sender, System.ComponentModel.CancelEventArgs e)
        {
            openFileDialog_TD.ShowDialog();
            openFilePath = openFileDialog_TD.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialog_TD.FileName;
            buttonDone_TD.Enabled = true;
        }
        private void buttonHelp_TD_Click(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
