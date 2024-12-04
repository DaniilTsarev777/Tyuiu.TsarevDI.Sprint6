namespace Tyuiu.TsarevDI.Sprint6.Task2.V8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            condition = new Label();
            conditionOfTask = new Label();
            pictureBox1 = new PictureBox();
            start = new Label();
            stop = new Label();
            input = new Label();
            textBox_StartValue = new TextBox();
            textBox_StopValue = new TextBox();
            Buttone_Done = new Button();
            Buttonie_info = new Button();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // condition
            // 
            condition.AutoSize = true;
            condition.BackColor = SystemColors.ActiveCaption;
            condition.Location = new Point(60, 42);
            condition.Name = "condition";
            condition.Size = new Size(53, 15);
            condition.TabIndex = 0;
            condition.Text = "Условие";
            // 
            // conditionOfTask
            // 
            conditionOfTask.AutoSize = true;
            conditionOfTask.BackColor = SystemColors.ActiveCaption;
            conditionOfTask.Location = new Point(60, 68);
            conditionOfTask.Name = "conditionOfTask";
            conditionOfTask.Size = new Size(295, 15);
            conditionOfTask.TabIndex = 1;
            conditionOfTask.Text = "Протабулировать функцию на заданном диапазоне.";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(524, 67);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // start
            // 
            start.AutoSize = true;
            start.BackColor = SystemColors.ActiveCaption;
            start.Location = new Point(60, 362);
            start.Name = "start";
            start.Size = new Size(67, 15);
            start.TabIndex = 3;
            start.Text = "старт шага";
            // 
            // stop
            // 
            stop.AutoSize = true;
            stop.BackColor = SystemColors.ActiveCaption;
            stop.Location = new Point(235, 362);
            stop.Name = "stop";
            stop.Size = new Size(71, 15);
            stop.TabIndex = 4;
            stop.Text = "конец шага";
            stop.Click += stop_Click;
            // 
            // input
            // 
            input.AutoSize = true;
            input.BackColor = SystemColors.ActiveCaption;
            input.Location = new Point(60, 330);
            input.Name = "input";
            input.Size = new Size(79, 15);
            input.TabIndex = 5;
            input.Text = "ввод данных:";
            // 
            // textBox_StartValue
            // 
            textBox_StartValue.Location = new Point(60, 395);
            textBox_StartValue.Name = "textBox_StartValue";
            textBox_StartValue.Size = new Size(100, 23);
            textBox_StartValue.TabIndex = 6;
            textBox_StartValue.KeyPress += textBox_StartValue_KeyPress;
            // 
            // textBox_StopValue
            // 
            textBox_StopValue.Location = new Point(235, 395);
            textBox_StopValue.Name = "textBox_StopValue";
            textBox_StopValue.Size = new Size(100, 23);
            textBox_StopValue.TabIndex = 7;
            textBox_StopValue.KeyPress += textBox_StopValue_KeyPress;
            // 
            // Buttone_Done
            // 
            Buttone_Done.BackColor = Color.Orange;
            Buttone_Done.Location = new Point(498, 374);
            Buttone_Done.Name = "Buttone_Done";
            Buttone_Done.Size = new Size(86, 44);
            Buttone_Done.TabIndex = 8;
            Buttone_Done.Text = "выполнить";
            Buttone_Done.UseVisualStyleBackColor = false;
            Buttone_Done.Click += ButtonDone_Click;
            // 
            // Buttonie_info
            // 
            Buttonie_info.BackColor = Color.Chartreuse;
            Buttonie_info.Location = new Point(391, 395);
            Buttonie_info.Name = "Buttonie_info";
            Buttonie_info.Size = new Size(75, 23);
            Buttonie_info.TabIndex = 9;
            Buttonie_info.Text = "info";
            Buttonie_info.UseVisualStyleBackColor = false;
            Buttonie_info.Click += ButtonHelp_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridView1.Location = new Point(687, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(142, 323);
            dataGridView1.TabIndex = 10;
            dataGridView1.ReadOnlyChanged += textBoxResult_TextChanged;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F(X)";
            F.Name = "F";
            F.ReadOnly = true;
            F.Width = 50;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(890, 95);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(404, 323);
            chart1.TabIndex = 11;
            chart1.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 450);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(Buttonie_info);
            Controls.Add(Buttone_Done);
            Controls.Add(textBox_StopValue);
            Controls.Add(textBox_StartValue);
            Controls.Add(input);
            Controls.Add(stop);
            Controls.Add(start);
            Controls.Add(pictureBox1);
            Controls.Add(conditionOfTask);
            Controls.Add(condition);
            Name = "FormMain";
            Text = "Спринт 6|Таск2|Вариант 8|Царёв.Д.И.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label condition;
        private Label conditionOfTask;
        private PictureBox pictureBox1;
        private Label start;
        private Label stop;
        private Label input;
        private TextBox textBox_StartValue;
        private TextBox textBox_StopValue;
        private Button Buttone_Done;
        private Button Buttonie_info;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
