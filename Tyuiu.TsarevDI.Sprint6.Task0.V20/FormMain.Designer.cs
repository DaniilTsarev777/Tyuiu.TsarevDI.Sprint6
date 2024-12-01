using System.Windows.Forms;
using Tyuiu.TsarevDI.Sprint6.Task0.V20.Properties;

namespace Tyuiu.TsarevDI.Sprint6.Task0.V20
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
            pictureBox1 = new PictureBox();
            textBoxResult = new TextBox();
            ResultLabel = new Label();
            textBoxVarX = new TextBox();
            varlabel = new Label();
            conditionlabel = new Label();
            ButtonDone = new Button();
            buttonhelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.pictureBoxTaskImage;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // textBoxResult
            // 
            resources.ApplyResources(textBoxResult, "textBoxResult");
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // ResultLabel
            // 
            resources.ApplyResources(ResultLabel, "ResultLabel");
            ResultLabel.BackColor = Color.MidnightBlue;
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Click += label1_Click;
            // 
            // textBoxVarX
            // 
            resources.ApplyResources(textBoxVarX, "textBoxVarX");
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // varlabel
            // 
            resources.ApplyResources(varlabel, "varlabel");
            varlabel.BackColor = Color.SandyBrown;
            varlabel.Name = "varlabel";
            varlabel.Click += label2_Click;
            // 
            // conditionlabel
            // 
            resources.ApplyResources(conditionlabel, "conditionlabel");
            conditionlabel.BackColor = Color.RoyalBlue;
            conditionlabel.Name = "conditionlabel";
            // 
            // ButtonDone
            // 
            ButtonDone.BackColor = Color.RebeccaPurple;
            resources.ApplyResources(ButtonDone, "ButtonDone");
            ButtonDone.Name = "ButtonDone";
            ButtonDone.UseVisualStyleBackColor = false;
            ButtonDone.Enter += ButtonDone_Click;
            // 
            // buttonhelp
            // 
            buttonhelp.BackColor = Color.Peru;
            resources.ApplyResources(buttonhelp, "buttonhelp");
            buttonhelp.Name = "buttonhelp";
            buttonhelp.UseVisualStyleBackColor = false;
            buttonhelp.Enter += buttonhelp_Click;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(buttonhelp);
            Controls.Add(ButtonDone);
            Controls.Add(conditionlabel);
            Controls.Add(varlabel);
            Controls.Add(textBoxVarX);
            Controls.Add(ResultLabel);
            Controls.Add(textBoxResult);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonFace;
            HelpButton = true;
            KeyPreview = true;
            Name = "FormMain";
            Load += FormMain_Load;
            KeyPress += textBoxVarX_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxResult;
        private Label ResultLabel;
        private TextBox textBoxVarX;
        private Label varlabel;
        private Label conditionlabel;
        private Button ButtonDone;
        private Button buttonhelp;
    }
}
