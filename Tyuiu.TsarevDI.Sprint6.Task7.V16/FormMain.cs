using Tyuiu.TsarevDI.Sprint6.Task7.V16.Lib;
namespace Tyuiu.TsarevDI.Sprint6.Task7.V16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialogMatrix_TDI.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_TDI.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }
        private void buttonOpenFile_TDI_Click(object sender, EventArgs e)
        {
            openFileDialogMatrix_TDI.ShowDialog();
            openFilePath = openFileDialogMatrix_TDI.FileName;

            rows = 10;
            columns = 10;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_TDI.ColumnCount = columns;
            dataGridViewInMatrix_TDI.RowCount = rows;
            dataGridViewOutMatrix_TDI.ColumnCount = columns;
            dataGridViewOutMatrix_TDI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_TDI.Columns[i].Width = 25;
                dataGridViewOutMatrix_TDI.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_TDI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

        }
        private void buttonSaveFile_TDI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_TDI.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_TDI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_TDI.ShowDialog();

            string path = saveFileDialogMatrix_TDI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_TDI.RowCount;
            int columns = dataGridViewOutMatrix_TDI.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_TDI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_TDI.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonDone_TDI_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_TDI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            ///buttonSaveFile_TDI.Enabled = true;
        }
        private void Fomr1_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix_TDI.ColumnCount = 50;
            dataGridViewInMatrix_TDI.RowCount = 50;
            dataGridViewOutMatrix_TDI.ColumnCount = 50;
            dataGridViewOutMatrix_TDI.ColumnCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_TDI.Columns[i].Width = 25;
                dataGridViewOutMatrix_TDI.Columns[i].Width = 25;
            }
        }

        private void buttonHelp_TDI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

       
        
       
    }
}
