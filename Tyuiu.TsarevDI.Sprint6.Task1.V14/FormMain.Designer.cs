namespace Tyuiu.TsarevDI.Sprint6.Task1.V14
{
    partial class FormMain : Form
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
            condition = new Label();
            dataInput = new Label();
            start = new Label();
            label2 = new Label();
            textBox_StartValue = new TextBox();
            textBox_StopValue = new TextBox();
            help = new Button();
            done = new Button();
            output = new Label();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // condition
            // 
            condition.AutoSize = true;
            condition.BackColor = Color.BurlyWood;
            condition.Location = new Point(47, 34);
            condition.Name = "condition";
            condition.Size = new Size(293, 15);
            condition.TabIndex = 0;
            condition.Text = "Протабулировать функцию на заданном диапозоне";
            // 
            // dataInput
            // 
            dataInput.AutoSize = true;
            dataInput.BackColor = Color.BurlyWood;
            dataInput.Location = new Point(47, 354);
            dataInput.Name = "dataInput";
            dataInput.Size = new Size(77, 15);
            dataInput.TabIndex = 1;
            dataInput.Text = "Ввод данных";
            // 
            // start
            // 
            start.AutoSize = true;
            start.BackColor = Color.CadetBlue;
            start.Location = new Point(47, 369);
            start.Name = "start";
            start.Size = new Size(72, 15);
            start.TabIndex = 2;
            start.Text = "Старт шага:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CadetBlue;
            label2.Location = new Point(180, 369);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Конец шага:";
            label2.Click += label2_Click;
            // 
            // textBox_StartValue
            // 
            textBox_StartValue.Location = new Point(47, 397);
            textBox_StartValue.Name = "textBox_StartValue";
            textBox_StartValue.Size = new Size(100, 23);
            textBox_StartValue.TabIndex = 4;
            textBox_StartValue.KeyPress += textBox_StartValue_KeyPress;
            // 
            // textBox_StopValue
            // 
            textBox_StopValue.Location = new Point(180, 397);
            textBox_StopValue.Name = "textBox_StopValue";
            textBox_StopValue.Size = new Size(100, 23);
            textBox_StopValue.TabIndex = 5;
            textBox_StopValue.KeyPress += textBox_StopValue_KeyPress;
            // 
            // help
            // 
            help.BackColor = Color.BlanchedAlmond;
            help.Location = new Point(322, 369);
            help.Name = "help";
            help.Size = new Size(75, 51);
            help.TabIndex = 6;
            help.Text = "Справка";
            help.UseVisualStyleBackColor = false;
            help.Enter += buttonhelp_Click;
            // 
            // done
            // 
            done.BackColor = Color.Chocolate;
            done.Location = new Point(420, 369);
            done.Name = "done";
            done.Size = new Size(115, 51);
            done.TabIndex = 7;
            done.Text = "Выполнить";
            done.UseVisualStyleBackColor = false;
            done.Enter += buttonDone_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.BackColor = Color.Bisque;
            output.Location = new Point(568, 34);
            output.Name = "output";
            output.Size = new Size(89, 15);
            output.TabIndex = 8;
            output.Text = "Вывод данных:";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(568, 69);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(220, 351);
            textBoxResult.TabIndex = 9;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(output);
            Controls.Add(done);
            Controls.Add(help);
            Controls.Add(textBox_StopValue);
            Controls.Add(textBox_StartValue);
            Controls.Add(label2);
            Controls.Add(start);
            Controls.Add(dataInput);
            Controls.Add(condition);
            Name = "FormMain";
            Text = "Спринт 6|Таск1|Вариант 14|Царёв.Д.И.";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label condition;
        private Label dataInput;
        private Label start;
        private Label label2;
        private TextBox textBox_StartValue;
        private TextBox textBox_StopValue;
        private Button help;
        private Button done;
        private Label output;
        private TextBox textBoxResult;
    }
}
