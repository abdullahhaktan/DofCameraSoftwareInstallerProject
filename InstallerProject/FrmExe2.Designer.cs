namespace InstallerProject
{
    partial class FrmExe2
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
            this.progressBarExe2 = new System.Windows.Forms.ProgressBar();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarExe2
            // 
            this.progressBarExe2.Location = new System.Drawing.Point(264, 145);
            this.progressBarExe2.Name = "progressBarExe2";
            this.progressBarExe2.Size = new System.Drawing.Size(389, 33);
            this.progressBarExe2.TabIndex = 6;
            // 
            // btnNext1
            // 
            this.btnNext1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext1.Location = new System.Drawing.Point(362, 267);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(166, 49);
            this.btnNext1.TabIndex = 5;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = false;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Situation:";
            // 
            // FrmExe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(833, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarExe2);
            this.Controls.Add(this.btnNext1);
            this.Name = "FrmExe2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOF Camera Software Installer";
            this.Load += new System.EventHandler(this.FrmExe2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarExe2;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Label label1;
    }
}