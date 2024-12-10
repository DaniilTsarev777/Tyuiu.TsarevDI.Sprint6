namespace Tyuiu.TsarevDI.Sprint6.Task7.V16
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            devlabel_TD = new Label();
            grouplabel_TD = new Label();
            info = new Label();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 214);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // devlabel_TD
            // 
            devlabel_TD.AutoSize = true;
            devlabel_TD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            devlabel_TD.Location = new Point(491, 57);
            devlabel_TD.Name = "devlabel_TD";
            devlabel_TD.Size = new Size(198, 21);
            devlabel_TD.TabIndex = 2;
            devlabel_TD.Text = "Разработчик: Царёв.Д.И.\r\n";
            // 
            // grouplabel_TD
            // 
            grouplabel_TD.AutoSize = true;
            grouplabel_TD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grouplabel_TD.Location = new Point(491, 89);
            grouplabel_TD.Name = "grouplabel_TD";
            grouplabel_TD.Size = new Size(177, 21);
            grouplabel_TD.TabIndex = 3;
            grouplabel_TD.Text = "Группа: СМАРТб-24-1";
            // 
            // info
            // 
            info.AutoSize = true;
            info.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            info.Location = new Point(491, 129);
            info.Name = "info";
            info.Size = new Size(67, 100);
            info.TabIndex = 4;
            info.Text = "ТИУ\r\nВШЦТ\r\n2k24\r\n(с)";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(600, 244);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(89, 28);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 288);
            Controls.Add(buttonOk);
            Controls.Add(info);
            Controls.Add(grouplabel_TD);
            Controls.Add(devlabel_TD);
            Controls.Add(pictureBox1);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label devlabel_TD;
        private Label grouplabel_TD;
        private Label info;
        private Button buttonOk;
    }
}