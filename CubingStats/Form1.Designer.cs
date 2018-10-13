namespace CubingStats
{
    partial class ConsecutiveInd
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
            this.statsControl2 = new CubingStats.StatsControl();
            this.statsControl1 = new CubingStats.StatsControl();
            this.SuspendLayout();
            // 
            // statsControl2
            // 
            this.statsControl2.Location = new System.Drawing.Point(760, 0);
            this.statsControl2.Name = "statsControl2";
            this.statsControl2.Size = new System.Drawing.Size(700, 800);
            this.statsControl2.TabIndex = 1;
            // 
            // statsControl1
            // 
            this.statsControl1.Location = new System.Drawing.Point(20, 0);
            this.statsControl1.Name = "statsControl1";
            this.statsControl1.Size = new System.Drawing.Size(700, 800);
            this.statsControl1.TabIndex = 0;
            // 
            // ConsecutiveInd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 796);
            this.Controls.Add(this.statsControl2);
            this.Controls.Add(this.statsControl1);
            this.Name = "ConsecutiveInd";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private StatsControl statsControl1;
        private StatsControl statsControl2;
    }
}

