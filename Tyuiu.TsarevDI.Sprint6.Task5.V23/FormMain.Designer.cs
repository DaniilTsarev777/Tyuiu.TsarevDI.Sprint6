namespace Tyuiu.TsarevDI.Sprint6.Task5.V23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            condition_TsarevDI = new Label();
            label2 = new Label();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            buttonHelp = new Button();
            label1 = new Label();
            dataGridViewNums = new DataGridView();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            SuspendLayout();
            // 
            // condition_TsarevDI
            // 
            condition_TsarevDI.AutoSize = true;
            condition_TsarevDI.Location = new Point(30, 9);
            condition_TsarevDI.Name = "condition_TsarevDI";
            condition_TsarevDI.Size = new Size(56, 15);
            condition_TsarevDI.TabIndex = 0;
            condition_TsarevDI.Text = "Условие:";
            condition_TsarevDI.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 117);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Вывод данных:";
            label2.Click += label2_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(586, 39);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(83, 42);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Enter += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(701, 39);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(81, 42);
            buttonOpenFile.TabIndex = 3;
            buttonOpenFile.Text = "открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Enter += buttonOpenFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(813, 39);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(79, 42);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Enter += buttonHelp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(479, 60);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Location = new Point(30, 135);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.Size = new Size(240, 393);
            dataGridViewNums.TabIndex = 7;
            dataGridViewNums.ReadOnlyChanged += buttonDone_Click;
            // 
            // chartDiag
            // 
            chartArea2.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartDiag.Legends.Add(legend2);
            chartDiag.Location = new Point(427, 135);
            chartDiag.Name = "chartDiag";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartDiag.Series.Add(series2);
            chartDiag.Size = new Size(465, 393);
            chartDiag.TabIndex = 8;
            chartDiag.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 540);
            Controls.Add(chartDiag);
            Controls.Add(dataGridViewNums);
            Controls.Add(label1);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOpenFile);
            Controls.Add(buttonDone);
            Controls.Add(label2);
            Controls.Add(condition_TsarevDI);
            Name = "FormMain";
            Text = "Спринт 6|Таск5|Вариант 23|Царёв.Д.И.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label condition_TsarevDI;
        private Label label2;
        private Button buttonDone;
        private Button buttonOpenFile;
        private Button buttonHelp;
        private Label label1;
        private DataGridView dataGridViewNums;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
    }
}
