namespace Tyuiu.TsarevDI.Sprint6.Task6.V19
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            conditionlabel_TD = new Label();
            pictureBox1 = new PictureBox();
            textBoxLoadFromFile = new TextBox();
            textBoxResult = new TextBox();
            inputlabel_TD = new Label();
            outputlabel_TD = new Label();
            openFileDialog_TD = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            openFilePath = new Button();
            buttonDone_TD = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // conditionlabel_TD
            // 
            conditionlabel_TD.AutoSize = true;
            conditionlabel_TD.Location = new Point(12, 9);
            conditionlabel_TD.Name = "conditionlabel_TD";
            conditionlabel_TD.Size = new Size(56, 15);
            conditionlabel_TD.TabIndex = 0;
            conditionlabel_TD.Text = "Условие:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(726, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(24, 216);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ReadOnly = true;
            textBoxLoadFromFile.ScrollBars = ScrollBars.Both;
            textBoxLoadFromFile.Size = new Size(467, 339);
            textBoxLoadFromFile.TabIndex = 2;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(631, 216);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Both;
            textBoxResult.Size = new Size(439, 339);
            textBoxResult.TabIndex = 3;
            // 
            // inputlabel_TD
            // 
            inputlabel_TD.AutoSize = true;
            inputlabel_TD.Location = new Point(24, 178);
            inputlabel_TD.Name = "inputlabel_TD";
            inputlabel_TD.Size = new Size(36, 15);
            inputlabel_TD.TabIndex = 4;
            inputlabel_TD.Text = "Ввод:";
            // 
            // outputlabel_TD
            // 
            outputlabel_TD.AutoSize = true;
            outputlabel_TD.Location = new Point(631, 178);
            outputlabel_TD.Name = "outputlabel_TD";
            outputlabel_TD.Size = new Size(45, 15);
            outputlabel_TD.TabIndex = 5;
            outputlabel_TD.Text = "Вывод:";
            // 
            // openFileDialog_TD
            // 
            openFileDialog_TD.FileName = "openFileDialog_TD";
            openFileDialog_TD.FileOk += openFileDialog1_FileOk;
            // 
            // openFilePath
            // 
            openFilePath.Location = new Point(24, 114);
            openFilePath.Name = "openFilePath";
            openFilePath.Size = new Size(104, 44);
            openFilePath.TabIndex = 6;
            openFilePath.Text = "File";
            openFilePath.UseVisualStyleBackColor = true;
            // 
            // buttonDone_TD
            // 
            buttonDone_TD.Location = new Point(166, 114);
            buttonDone_TD.Name = "buttonDone_TD";
            buttonDone_TD.Size = new Size(104, 44);
            buttonDone_TD.TabIndex = 7;
            buttonDone_TD.Text = "Выполнить";
            buttonDone_TD.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button3.Location = new Point(990, 15);
            button3.Name = "button3";
            button3.Size = new Size(69, 62);
            button3.TabIndex = 8;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 588);
            Controls.Add(button3);
            Controls.Add(buttonDone_TD);
            Controls.Add(openFilePath);
            Controls.Add(outputlabel_TD);
            Controls.Add(inputlabel_TD);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxLoadFromFile);
            Controls.Add(pictureBox1);
            Controls.Add(conditionlabel_TD);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label conditionlabel_TD;
        private PictureBox pictureBox1;
        private TextBox textBoxLoadFromFile;
        private TextBox textBoxResult;
        private Label inputlabel_TD;
        private Label outputlabel_TD;
        private OpenFileDialog openFileDialog_TD;
        private ToolTip toolTip1;
        private Button openFilePath;
        private Button buttonDone_TD;
        private Button button3;
    }
}
