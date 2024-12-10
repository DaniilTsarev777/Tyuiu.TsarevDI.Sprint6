
namespace Tyuiu.TsarevDI.Sprint6.Task6.V19
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
            buttonClose_TD = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 214);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // devlabel_TD
            // 
            devlabel_TD.AutoSize = true;
            devlabel_TD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            devlabel_TD.Location = new Point(455, 24);
            devlabel_TD.Name = "devlabel_TD";
            devlabel_TD.Size = new Size(198, 21);
            devlabel_TD.TabIndex = 1;
            devlabel_TD.Text = "Разработчик: Царёв.Д.И.\r\n";
            // 
            // grouplabel_TD
            // 
            grouplabel_TD.AutoSize = true;
            grouplabel_TD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grouplabel_TD.Location = new Point(455, 62);
            grouplabel_TD.Name = "grouplabel_TD";
            grouplabel_TD.Size = new Size(177, 21);
            grouplabel_TD.TabIndex = 2;
            grouplabel_TD.Text = "Группа: СМАРТб-24-1";
            // 
            // info
            // 
            info.AutoSize = true;
            info.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            info.Location = new Point(455, 104);
            info.Name = "info";
            info.Size = new Size(67, 100);
            info.TabIndex = 3;
            info.Text = "ТИУ\r\nВШЦТ\r\n2k24\r\n(с)";
            // 
            // buttonClose_TD
            // 
            buttonClose_TD.Location = new Point(625, 204);
            buttonClose_TD.Name = "buttonClose_TD";
            buttonClose_TD.Size = new Size(126, 43);
            buttonClose_TD.TabIndex = 4;
            buttonClose_TD.Text = "OK";
            buttonClose_TD.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(782, 267);
            Controls.Add(buttonClose_TD);
            Controls.Add(info);
            Controls.Add(grouplabel_TD);
            Controls.Add(devlabel_TD);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            Load += this.FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label devlabel_TD;
        private Label grouplabel_TD;
        private Label info;
        private Button buttonClose_TD;
    }
}