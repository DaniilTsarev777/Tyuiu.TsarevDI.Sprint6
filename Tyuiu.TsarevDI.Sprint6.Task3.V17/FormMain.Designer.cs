namespace Tyuiu.TsarevDI.Sprint6.Task3.V17
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
            condition = new Label();
            label1 = new Label();
            dataGridViewMatrix_TsarevDI = new DataGridView();
            buttonDone = new Button();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_TsarevDI).BeginInit();
            SuspendLayout();
            // 
            // condition
            // 
            condition.AutoSize = true;
            condition.BackColor = SystemColors.ButtonShadow;
            condition.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            condition.ForeColor = SystemColors.ControlText;
            condition.Location = new Point(51, 35);
            condition.Name = "condition";
            condition.Size = new Size(92, 30);
            condition.TabIndex = 0;
            condition.Text = "Условие";
            condition.Click += condition_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(51, 76);
            label1.Name = "label1";
            label1.Size = new Size(453, 189);
            label1.TabIndex = 1;
            label1.Text = "Дана матрица 5 на 5\r\n\r\n22  32 -16  24  27\r\n3 -20  24 -20  25\r\n21  17  -8 -19  17\r\n8  22  28  27  19\r\n11  20  12  27  29\r\n\r\nВыполнить сортировку по возрастанию в четвертом столбце.";
            // 
            // dataGridViewMatrix_TsarevDI
            // 
            dataGridViewMatrix_TsarevDI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_TsarevDI.ColumnHeadersVisible = false;
            dataGridViewMatrix_TsarevDI.Location = new Point(510, 35);
            dataGridViewMatrix_TsarevDI.Name = "dataGridViewMatrix_TsarevDI";
            dataGridViewMatrix_TsarevDI.RowHeadersVisible = false;
            dataGridViewMatrix_TsarevDI.Size = new Size(489, 253);
            dataGridViewMatrix_TsarevDI.TabIndex = 2;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Brown;
            buttonDone.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDone.Location = new Point(510, 309);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(278, 63);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "ИГРАТЬ";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.AppWorkspace;
            buttonHelp.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHelp.Location = new Point(51, 309);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(113, 63);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "INFO";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(dataGridViewMatrix_TsarevDI);
            Controls.Add(label1);
            Controls.Add(condition);
            Name = "FormMain";
            Text = "Спринт 6|Таск3|Вариант 17|Царёв.Д.И.";
            ///Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_TsarevDI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label condition;
        private Label label1;
        private DataGridView dataGridViewMatrix_TsarevDI;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
