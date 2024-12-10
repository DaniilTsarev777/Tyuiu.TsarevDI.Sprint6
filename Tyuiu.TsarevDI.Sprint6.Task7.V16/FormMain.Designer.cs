namespace Tyuiu.TsarevDI.Sprint6.Task7.V16
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonOpenFile_TDI = new Button();
            buttonDone_TDI = new Button();
            buttonSaveFile_TDI = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewInMatrix_TDI = new DataGridView();
            dataGridViewOutMatrix_TDI = new DataGridView();
            buttonHelp_TDI = new Button();
            label2 = new Label();
            label3 = new Label();
            openFileDialogMatrix_TDI = new OpenFileDialog();
            saveFileDialogMatrix_TDI = new SaveFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_TDI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_TDI).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenFile_TDI
            // 
            buttonOpenFile_TDI.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOpenFile_TDI.Location = new Point(12, 12);
            buttonOpenFile_TDI.Name = "buttonOpenFile_TDI";
            buttonOpenFile_TDI.Size = new Size(99, 65);
            buttonOpenFile_TDI.TabIndex = 0;
            buttonOpenFile_TDI.Text = "OPEN FILE";
            buttonOpenFile_TDI.UseVisualStyleBackColor = true;
            buttonOpenFile_TDI.Enter += buttonOpenFile_TDI_Click;
            // 
            // buttonDone_TDI
            // 
            buttonDone_TDI.Enabled = false;
            buttonDone_TDI.Location = new Point(250, 12);
            buttonDone_TDI.Name = "buttonDone_TDI";
            buttonDone_TDI.Size = new Size(99, 65);
            buttonDone_TDI.TabIndex = 1;
            buttonDone_TDI.Text = "Выполнить";
            buttonDone_TDI.UseVisualStyleBackColor = true;
            buttonDone_TDI.Enter += buttonDone_TDI_Click;
            // 
            // buttonSaveFile_TDI
            // 
            buttonSaveFile_TDI.Enabled = false;
            buttonSaveFile_TDI.Location = new Point(131, 12);
            buttonSaveFile_TDI.Name = "buttonSaveFile_TDI";
            buttonSaveFile_TDI.Size = new Size(99, 65);
            buttonSaveFile_TDI.TabIndex = 2;
            buttonSaveFile_TDI.Text = "save file";
            buttonSaveFile_TDI.UseVisualStyleBackColor = true;
            buttonSaveFile_TDI.Enter += buttonSaveFile_TDI_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Условие:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(731, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewInMatrix_TDI
            // 
            dataGridViewInMatrix_TDI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_TDI.Location = new Point(12, 187);
            dataGridViewInMatrix_TDI.Name = "dataGridViewInMatrix_TDI";
            dataGridViewInMatrix_TDI.ReadOnly = true;
            dataGridViewInMatrix_TDI.Size = new Size(387, 349);
            dataGridViewInMatrix_TDI.TabIndex = 5;
            // 
            // dataGridViewOutMatrix_TDI
            // 
            dataGridViewOutMatrix_TDI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_TDI.Location = new Point(437, 187);
            dataGridViewOutMatrix_TDI.Name = "dataGridViewOutMatrix_TDI";
            dataGridViewOutMatrix_TDI.ReadOnly = true;
            dataGridViewOutMatrix_TDI.Size = new Size(387, 349);
            dataGridViewOutMatrix_TDI.TabIndex = 6;
            // 
            // buttonHelp_TDI
            // 
            buttonHelp_TDI.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_TDI.Location = new Point(725, 12);
            buttonHelp_TDI.Name = "buttonHelp_TDI";
            buttonHelp_TDI.Size = new Size(99, 65);
            buttonHelp_TDI.TabIndex = 7;
            buttonHelp_TDI.Text = "?";
            buttonHelp_TDI.UseVisualStyleBackColor = true;
            buttonHelp_TDI.Enter += buttonHelp_TDI_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 169);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Ввод:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 169);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 9;
            label3.Text = "Вывод:";
            // 
            // openFileDialogMatrix_TDI
            // 
            openFileDialogMatrix_TDI.FileName = "openFileDialog1";
            openFileDialogMatrix_TDI.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            ///saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 544);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonHelp_TDI);
            Controls.Add(dataGridViewOutMatrix_TDI);
            Controls.Add(dataGridViewInMatrix_TDI);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(buttonSaveFile_TDI);
            Controls.Add(buttonDone_TDI);
            Controls.Add(buttonOpenFile_TDI);
            Name = "Form1";
            Text = "Спринт 6|Таск7|Вариант 16|Царёв.Д.И.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_TDI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_TDI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenFile_TDI;
        private Button buttonDone_TDI;
        private Button buttonSaveFile_TDI;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewInMatrix_TDI;
        private DataGridView dataGridViewOutMatrix_TDI;
        private Button buttonHelp_TDI;
        private Label label2;
        private Label label3;
        private OpenFileDialog openFileDialogMatrix_TDI;
        private SaveFileDialog saveFileDialogMatrix_TDI;
        private SaveFileDialog saveFileDialog1;
    }
}
