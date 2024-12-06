namespace Tyuiu.TsarevDI.Sprint6.Task4.V8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            condition_TsarevDI = new Label();
            input_TsarevDI = new Label();
            startValue_TsarevDI_label = new Label();
            stopValue_TsarevDI_label = new Label();
            startValue_TsarevDI = new TextBox();
            stopValue_TsarevDI = new TextBox();
            textBoxResult = new TextBox();
            buttonDone_TsarevDI = new Button();
            buttonSave_TsarevDI = new Button();
            buttonHelp_TsarevDI = new Button();
            output_TsarevDI = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // condition_TsarevDI
            // 
            condition_TsarevDI.AutoSize = true;
            condition_TsarevDI.Location = new Point(12, 9);
            condition_TsarevDI.Name = "condition_TsarevDI";
            condition_TsarevDI.Size = new Size(53, 15);
            condition_TsarevDI.TabIndex = 0;
            condition_TsarevDI.Text = "Условие";
            // 
            // input_TsarevDI
            // 
            input_TsarevDI.AutoSize = true;
            input_TsarevDI.Location = new Point(269, 9);
            input_TsarevDI.Name = "input_TsarevDI";
            input_TsarevDI.Size = new Size(79, 15);
            input_TsarevDI.TabIndex = 1;
            input_TsarevDI.Text = "Ввод Данных";
            // 
            // startValue_TsarevDI_label
            // 
            startValue_TsarevDI_label.AutoSize = true;
            startValue_TsarevDI_label.Location = new Point(269, 33);
            startValue_TsarevDI_label.Name = "startValue_TsarevDI_label";
            startValue_TsarevDI_label.Size = new Size(72, 15);
            startValue_TsarevDI_label.TabIndex = 2;
            startValue_TsarevDI_label.Text = "Старт шага:";
            // 
            // stopValue_TsarevDI_label
            // 
            stopValue_TsarevDI_label.AutoSize = true;
            stopValue_TsarevDI_label.Location = new Point(399, 33);
            stopValue_TsarevDI_label.Name = "stopValue_TsarevDI_label";
            stopValue_TsarevDI_label.Size = new Size(75, 15);
            stopValue_TsarevDI_label.TabIndex = 3;
            stopValue_TsarevDI_label.Text = "Конец шага:";
            // 
            // startValue_TsarevDI
            // 
            startValue_TsarevDI.Location = new Point(269, 63);
            startValue_TsarevDI.Name = "startValue_TsarevDI";
            startValue_TsarevDI.Size = new Size(100, 23);
            startValue_TsarevDI.TabIndex = 4;
            startValue_TsarevDI.KeyPress += startValue_KeyPress;
            // 
            // stopValue_TsarevDI
            // 
            stopValue_TsarevDI.Location = new Point(399, 63);
            stopValue_TsarevDI.Name = "stopValue_TsarevDI";
            stopValue_TsarevDI.Size = new Size(100, 23);
            stopValue_TsarevDI.TabIndex = 5;
            stopValue_TsarevDI.KeyPress += stopValue_KeyPress;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(12, 98);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(195, 340);
            textBoxResult.TabIndex = 6;
            textBoxResult.TextChanged += buttonDone_Click;
            // 
            // buttonDone_TsarevDI
            // 
            buttonDone_TsarevDI.Location = new Point(542, 33);
            buttonDone_TsarevDI.Name = "buttonDone_TsarevDI";
            buttonDone_TsarevDI.Size = new Size(82, 52);
            buttonDone_TsarevDI.TabIndex = 7;
            buttonDone_TsarevDI.Text = "Выполнить";
            buttonDone_TsarevDI.UseVisualStyleBackColor = true;
            buttonDone_TsarevDI.Enter += buttonDone_Click;
            // 
            // buttonSave_TsarevDI
            // 
            buttonSave_TsarevDI.Location = new Point(647, 33);
            buttonSave_TsarevDI.Name = "buttonSave_TsarevDI";
            buttonSave_TsarevDI.Size = new Size(75, 52);
            buttonSave_TsarevDI.TabIndex = 8;
            buttonSave_TsarevDI.Text = "Сохранить";
            buttonSave_TsarevDI.UseVisualStyleBackColor = true;
            buttonSave_TsarevDI.Enter += buttonSave_Click;
            // 
            // buttonHelp_TsarevDI
            // 
            buttonHelp_TsarevDI.Location = new Point(741, 33);
            buttonHelp_TsarevDI.Name = "buttonHelp_TsarevDI";
            buttonHelp_TsarevDI.Size = new Size(75, 53);
            buttonHelp_TsarevDI.TabIndex = 9;
            buttonHelp_TsarevDI.Text = "Справка";
            buttonHelp_TsarevDI.UseVisualStyleBackColor = true;
            buttonHelp_TsarevDI.Enter += buttonHelp_Click;
            // 
            // output_TsarevDI
            // 
            output_TsarevDI.AutoSize = true;
            output_TsarevDI.Location = new Point(12, 63);
            output_TsarevDI.Name = "output_TsarevDI";
            output_TsarevDI.Size = new Size(45, 15);
            output_TsarevDI.TabIndex = 10;
            output_TsarevDI.Text = "Вывод:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(269, 98);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(547, 340);
            chart1.TabIndex = 11;
            chart1.Text = "chart1";
            title2.BackColor = Color.FromArgb(128, 255, 255);
            title2.Name = "Title1";
            title2.Text = "График заданной функции";
            chart1.Titles.Add(title2);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 450);
            Controls.Add(chart1);
            Controls.Add(output_TsarevDI);
            Controls.Add(buttonHelp_TsarevDI);
            Controls.Add(buttonSave_TsarevDI);
            Controls.Add(buttonDone_TsarevDI);
            Controls.Add(textBoxResult);
            Controls.Add(stopValue_TsarevDI);
            Controls.Add(startValue_TsarevDI);
            Controls.Add(stopValue_TsarevDI_label);
            Controls.Add(startValue_TsarevDI_label);
            Controls.Add(input_TsarevDI);
            Controls.Add(condition_TsarevDI);
            Name = "FormMain";
            Text = "Спринт 6|Таск4|Вариант 8|Царёв.Д.И.";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label condition_TsarevDI;
        private Label input_TsarevDI;
        private Label startValue_TsarevDI_label;
        private Label stopValue_TsarevDI_label;
        private TextBox startValue_TsarevDI;
        private TextBox stopValue_TsarevDI;
        private TextBox textBoxResult;
        private Button buttonDone_TsarevDI;
        private Button buttonSave_TsarevDI;
        private Button buttonHelp_TsarevDI;
        private Label output_TsarevDI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
