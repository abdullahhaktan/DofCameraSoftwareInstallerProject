namespace InstallerProject
{
    partial class FrmPath
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarPath = new System.Windows.Forms.ProgressBar();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Situation:";
            // 
            // progressBarPath
            // 
            this.progressBarPath.Location = new System.Drawing.Point(263, 141);
            this.progressBarPath.Name = "progressBarPath";
            this.progressBarPath.Size = new System.Drawing.Size(389, 33);
            this.progressBarPath.TabIndex = 9;
            // 
            // btnNext2
            // 
            this.btnNext2.BackColor = System.Drawing.SystemColors.Window;
            this.btnNext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext2.Location = new System.Drawing.Point(348, 245);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(166, 49);
            this.btnNext2.TabIndex = 8;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = false;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // FrmPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarPath);
            this.Controls.Add(this.btnNext2);
            this.Name = "FrmPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOF Camera Software Installer";
            this.Load += new System.EventHandler(this.FrmPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarPath;
        private System.Windows.Forms.Button btnNext2;
    }
}